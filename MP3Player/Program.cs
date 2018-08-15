using System;
using System.Windows.Forms;
using MP3Player.Presenters;
using MP3Player.Views;

namespace MP3Player
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var form = new MainForm();
            var presenter = new Presenter(form);
            Application.Run(form);
        }
    }
}