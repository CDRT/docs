using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace investigator
{
    class WebFileDownloader
    {
        public event AmountDownloadedChangedEventHandler AmountDownloadedChanged;

        public delegate void AmountDownloadedChangedEventHandler(long iNewProgress);
        public event FileDownloadSizeObtainedEventHandler FileDownloadSizeObtained;

        public delegate void FileDownloadSizeObtainedEventHandler(long iFileSize);
        public event FileDownloadCompleteEventHandler FileDownloadComplete;

        public delegate void FileDownloadCompleteEventHandler();
        public event FileDownloadFailedEventHandler FileDownloadFailed;

        public delegate void FileDownloadFailedEventHandler(Exception ex);

        private string mCurrentFile = string.Empty;

        public string CurrentFile
        {
            get
            {
                return mCurrentFile;
            }
        }
        public bool DownloadFile(string URL, string Location)
        {
            try
            {
                mCurrentFile = GetFileName(URL);
                var WC = new WebClient();
                WC.DownloadFile(URL, Location);
                FileDownloadComplete?.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                FileDownloadFailed?.Invoke(ex);
                return false;
            }
        }

        private string GetFileName(string URL)
        {
            try
            {
                return URL.Substring(URL.LastIndexOf("/") + 1);
            }
            catch (Exception ex)
            {
                return URL;
            }
        }
        public bool DownloadFileWithProgress(string URL, string Location)
        {
            var FS = default(FileStream);
            try
            {
                mCurrentFile = GetFileName(URL);
                WebRequest wRemote;
                byte[] bBuffer;
                bBuffer = new byte[257];
                int iBytesRead;
                var iTotalBytesRead = default(int);

                FS = new FileStream(Location, FileMode.Create, FileAccess.Write);
                // add ticks to randomize and avoid cacheing
                wRemote = WebRequest.Create(URL + "?time=" + DateTime.Now.Ticks.ToString());

                // wRemote = WebRequest.Create(URL)

                // 'Avoid cacheing
                var noCachePolicy = new System.Net.Cache.HttpRequestCachePolicy(System.Net.Cache.HttpRequestCacheLevel.Refresh);
                wRemote.CachePolicy = noCachePolicy;


                WebResponse myWebResponse = wRemote.GetResponse();
                // If myWebResponse.IsFromCache Then
                // MsgBox("Cached!")

                // End If
                FileDownloadSizeObtained?.Invoke(myWebResponse.ContentLength);
                Stream sChunks = myWebResponse.GetResponseStream();
                do
                {
                    iBytesRead = sChunks.Read(bBuffer, 0, 256);
                    FS.Write(bBuffer, 0, iBytesRead);
                    iTotalBytesRead += iBytesRead;
                    if (myWebResponse.ContentLength < iTotalBytesRead)
                    {
                        AmountDownloadedChanged?.Invoke(myWebResponse.ContentLength);
                    }
                    else
                    {
                        AmountDownloadedChanged?.Invoke(iTotalBytesRead);
                    }
                }
                while (!(iBytesRead == 0));
                sChunks.Close();
                FS.Close();
                FileDownloadComplete?.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                if (FS != null)
                {
                    FS.Close();
                    FS = null;
                }

                FileDownloadFailed?.Invoke(ex);
                return false;
            }
        }

        public static string FormatFileSize(long Size)
        {
            try
            {
                int KB = 1024;
                int MB = KB * KB;
                // Return size of file in kilobytes.
                if (Size < KB)
                {
                    return Size.ToString("D") + " bytes";
                }
                else
                {
                    switch (Size / (double)KB)
                    {
                        // 'Case Is < 1000
                        // '    Return (Size / KB).ToString("N") & "KB"
                        case var @case when @case < 1000000d:
                            {
                                return (Size / (double)MB).ToString("N") + "MB";
                            }
                        case var case1 when case1 < 10000000d:
                            {
                                return (Size / (double)MB / KB).ToString("N") + "GB";
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                return Size.ToString();
            }

            return default;
        }
    }
}
