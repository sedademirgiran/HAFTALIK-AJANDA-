using HaftalikAjanda;
using System;
using System.Windows.Forms;

namespace HaftalikAjanda
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
