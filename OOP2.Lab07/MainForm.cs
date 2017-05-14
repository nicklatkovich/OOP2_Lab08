using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2.Lab07 {
    public partial class MainForm : Form {
        public MainForm( ) {
            InitializeComponent( );
            Load += MainForm_Load;
        }

        private void MainForm_Load(Object sender, EventArgs e) {
            GroupBoxAddAnimal.Visible = false;
        }

        private void ButtonAddAnimal_Click(Object sender, EventArgs e) {
            GroupBoxAddAnimal.Visible = true;
        }
    }
}
