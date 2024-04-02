using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUC_eSupportCompare
{

    static class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            string path = String.Format("{0}{1}{2}{3}{4}", "Log_", DateTime.Now.Month.ToString()
                                   , DateTime.Now.Day.ToString()
                                   , DateTime.Now.Year.ToString(), ".log");

            ChangeFilePath("RollingFile", path);

            log.Info("- - - - - - - - - - LUC_eSupportCompare (v" + Application.ProductVersion + ") Start - - - - - - - - - -");
            if (args.Length > 0)
            {
                log.Info("Running in NoGUI mode...");
                var me = new Form1(); // instantiate the form
                try
                {
                    if (AllocConsole())
                    {
                        log.Info("Begin NoGUI execution...");
                        Console.Out.WriteLine("Starting silent run");
                        me.NoGUI(args); // call the alternate entry point
                        Console.Out.WriteLine("Completed silent run");
                        FreeConsole();
                        log.Info("Ending in NoGUI mode...");
                    }//end if
                }//end try
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    log.Error(e.Message);
                }//end catch
            }//end if
            else
            {
                log.Info("Running in GUI mode...");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }//end else
        }//end main

        public static void ChangeFilePath(string appenderName, string newFilename)
        {
            log4net.Repository.ILoggerRepository repository = log4net.LogManager.GetRepository();
            foreach (log4net.Appender.IAppender appender in repository.GetAppenders())
            {
                if (appender.Name.CompareTo(appenderName) == 0 && appender is log4net.Appender.FileAppender)
                {
                    log4net.Appender.FileAppender fileAppender = (log4net.Appender.FileAppender)appender;
                    fileAppender.File = System.IO.Path.Combine(KnownFolders.GetPath(KnownFolder.Downloads) + "\\LUC_eSupport_Compare\\logs", newFilename);
                    fileAppender.ActivateOptions();
                }
            }
        }

    }
}
