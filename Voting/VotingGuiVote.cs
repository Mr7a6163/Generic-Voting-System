using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Voting
{
    public partial class VotingGuiVote : Form
    {
        string domain = ""; //ENTER YOUR DOMAIN HERE "test.com"
        string ftpdir = ""; //ENTER YOUR FTP DIRECTORY "dir" NO "/" AT THE FRONT, LEAVE BLANK IF NO SUBDIR
        string user = ""; //ENTER YOUR USERNAME "testuser"
        string pass = ""; //ENTER YOUR PASSWORD "testpassword"

        public VotingGuiVote()
        {
            InitializeComponent();
            VotingDownloadDetails.DownloadVote(domain,user,pass,dir);
            VotingDownloadCount.DownloadCount(domain,user,pass,dir);
        }

        private void VotingGuiVote_Load(object sender, EventArgs e)
        {
            string line1;
            string line2;
            string line3;
            string line4;
            string line5;
            string line6;
            string line7;

            line1 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(0).Take(1).First();
            line2 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(1).Take(1).First();
            line3 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(2).Take(1).First();
            line4 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(3).Take(1).First();
            line5 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(4).Take(1).First();
            line6 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(5).Take(1).First();
            line7 = File.ReadLines(Path.GetTempPath() + "VoteDetails.txt").Skip(6).Take(1).First();

            label1.Text = line1; //Set title
            label2.Text = line2; //Set date
            label5.Text = line3; //Set description

            listBox1.Items.Clear();
            listBox1.Items.Add(line4);
            listBox1.Items.Add(line5);
            listBox1.Items.Add(line6);
            listBox1.Items.Add(line7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listitem = listBox1.GetItemText(listBox1.SelectedItem);
            VotingAddToVote.AddToVote(textBox1.Text, textBox2.Text, listitem);
            VotingUpload.UploadCount(domain,user,pass,dir);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}
