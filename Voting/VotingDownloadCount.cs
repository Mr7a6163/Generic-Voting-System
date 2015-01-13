using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Voting
{
    class VotingDownloadCount
    {
        public static string DownloadCount()
        {
            string inputfilepath = Path.GetTempPath() + "VoteCount.txt";
            string ftphost = "www..com";
            string ftpfilepath = "/VoteCount.txt";

            string ftpfullpath = "ftp://" + ftphost + ftpfilepath;

            NetworkCredential credential = new NetworkCredential("username", "password");
            WebClient request1 = new WebClient();
            request1.Credentials = credential;
            request1.DownloadFile(ftpfullpath, inputfilepath);
            return "done";
        }
    }
}
