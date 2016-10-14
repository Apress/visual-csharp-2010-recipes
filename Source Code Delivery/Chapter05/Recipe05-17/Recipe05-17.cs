using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Apress.VisualCSharpRecipes.Chapter05
{
    static class Recipe05_17
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}