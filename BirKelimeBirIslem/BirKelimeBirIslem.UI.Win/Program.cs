﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirIslem.UI.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BirKelimeBirIslem.UI.Win.Forms.Anasayfa());

            //Application.Run(new BirKelimeBirIslem.UI.Win.Forms.KelimeForm.KelimeKarti());
            //Application.Run(new BirKelimeBirIslem.UI.Win.Forms.IslemForm.IslemKarti());

        }
    }
}
