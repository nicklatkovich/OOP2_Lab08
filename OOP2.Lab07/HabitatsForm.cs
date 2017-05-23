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
    public partial class HabitatsForm : Form {

        public HabitatsForm(AddAnimalForm addAnimalForm) {
            InitializeComponent( );
            GroupBoxEdit.Visible = false;
            AddAnimalForm = addAnimalForm;
        }

        private AddAnimalForm AddAnimalForm;

        private void ListBox_SelectedIndexChanged(Object sender, EventArgs e) {
            if (ListBoxHabitats.SelectedIndex >= 0) {
                if (ListBoxHabitats.SelectedItem.ToString( ) == "Добавить") {
                    ListBoxHabitats.Items.Insert(ListBoxHabitats.Items.Count - 1, new Habitat( ));
                    ListBoxHabitats.SelectedIndex--;
                } else {
                    TextBoxAz.Text = (ListBoxHabitats.SelectedItem as Habitat).Azimuth.ToString( );
                    TextBoxZen.Text = (ListBoxHabitats.SelectedItem as Habitat).Zenith.ToString( );
                    TextBoxArea.Text = (ListBoxHabitats.SelectedItem as Habitat).Area.ToString( );
                }
                GroupBoxEdit.Visible = true;
            }
        }

        private void TextBoxArea_TextChanged(Object sender, EventArgs e) {
            string text = TextBoxArea.Text;
            float res;
            if (float.TryParse(text, out res)) {
                int index = ListBoxHabitats.SelectedIndex;
                (ListBoxHabitats.Items[index] as Habitat).Area = res;
                ListBoxHabitats.Items[index] = ListBoxHabitats.Items[index];
                UpdateMainForm( );
            }
        }

        private void TextBoxAz_TextChanged(Object sender, EventArgs e) {
            string text = TextBoxAz.Text;
            float res;
            if (float.TryParse(text, out res)) {
                int index = ListBoxHabitats.SelectedIndex;
                (ListBoxHabitats.Items[index] as Habitat).Azimuth = res;
                ListBoxHabitats.Items[index] = ListBoxHabitats.Items[index];
                UpdateMainForm( );
            }
        }

        private void TextBoxZen_TextChanged(Object sender, EventArgs e) {
            string text = TextBoxZen.Text;
            float res;
            if (float.TryParse(text, out res)) {
                int index = ListBoxHabitats.SelectedIndex;
                (ListBoxHabitats.Items[index] as Habitat).Zenith = res;
                ListBoxHabitats.Items[index] = ListBoxHabitats.Items[index];
                UpdateMainForm( );
            }
        }

        private void UpdateMainForm( ) {
            uint count = 0u;
            float totalArea = 0f;
            foreach (var a in ListBoxHabitats.Items) {
                if (a is Habitat) {
                    count++;
                    totalArea += (a as Habitat).Area;
                }
            }
            AddAnimalForm.LabelHabitatsNumber.Text = "Зон: " + count;
            AddAnimalForm.LabelHabitatsArea.Text = "Площадь: " + totalArea + " км2";
        }

        private void ButtonDelete_Click(Object sender, EventArgs e) {
            ListBoxHabitats.Items.RemoveAt(ListBoxHabitats.SelectedIndex);
            GroupBoxEdit.Visible = false;
        }

        private void button1_Click(Object sender, EventArgs e) {
            this.Hide( );
            AddAnimalForm.Focus( );
        }
    }
}
