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
        public static string DownloadCount(string domain, string user, string pass, string ftpdir)
        {
            string inputfilepath = Path.GetTempPath() + "VoteCount.txt";
            string ftphost = domain;
            string ftpfilepath = "/VoteCount.txt";

            string ftpfullpath = "ftp://" + ftpdir + ftphost + ftpfilepath;

            NetworkCredential credential = new NetworkCredential(user, pass);
            WebClient request1 = new WebClient();
            request1.Credentials = credential;
            request1.DownloadFile(ftpfullpath, inputfilepath);
            return "done";
        }
    }
}
