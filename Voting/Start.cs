using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Voting
{
    class Start
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Main()
        {

            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);


            VotingGuiVote GUI = new VotingGuiVote();
            GUI.ShowDialog();
        }
    }
}
