using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP2.Lab08 {
    static class Program {

        public static MainForm MainForm;

        public static Color NormalBackColor = Color.FromArgb(60, 60, 60);
        public static Color ErrorBackColor = Color.Red;

        [STAThread]
        static void Main( ) {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm( );
            Application.Run(MainForm);
        }
    }
}
