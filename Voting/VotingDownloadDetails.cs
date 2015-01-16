using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Voting
{
    class VotingDownloadDetails
    {
        public static string DownloadVote(string domain, string user, string pass, string ftpdir)
        {
            string inputfilepath = Path.GetTempPath() + "VoteDetails.txt";
            string ftphost = domain;
            string ftpfilepath = "/VoteDetails.txt";

            string ftpfullpath = "ftp://" + ftphost + ftpdir + ftpfilepath;


            NetworkCredential credential = new NetworkCredential(user, pass);
            WebClient request1 = new WebClient();
            request1.Credentials = credential;
            request1.DownloadFile(ftpfullpath, inputfilepath);
            return "done";
        }
    }
}
