using System;
using System.Windows.Forms;

namespace OOP2.Lab07 {
    static class Program {

        public static MainForm MainForm;

        [STAThread]
        static void Main( ) {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm( );
            Application.Run(MainForm);
        }
    }
}
