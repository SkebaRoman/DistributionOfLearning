using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIApplication
{
    static class Program
    {
        /*!
	        \author Скеба Роман, Потапенко Микита, Шалагінов Андрій
	        \version 1.0 beta
	        \date 12.12.2016
        */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
