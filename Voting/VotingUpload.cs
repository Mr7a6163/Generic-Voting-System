using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Voting
{
    class VotingUpload
    {
        public static string UploadCount()
        {

            DontClose wait = new DontClose();
            wait.Show();

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www./VoteCount.txt");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential("username", "password");

            // Copy the entire contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader(Path.GetTempPath() + "VoteCount.txt");
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            // Upload the file stream to the server.
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            // Get the response from the FTP server.
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            // Close the connection = Happy a FTP server.
            response.Close();

            wait.Close();

            return "done";
        }
    }
}
