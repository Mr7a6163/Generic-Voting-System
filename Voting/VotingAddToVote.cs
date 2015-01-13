using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Voting
{
    class VotingAddToVote
    {
        public static string AddToVote(string name, string email, string option)
        {
            using (StreamWriter writer =
        new StreamWriter(Path.GetTempPath() + "VoteCount.txt"))
            {
                writer.WriteLine(name + " " + email + " " + option);
            }
            return "done";
        }
    }
}
