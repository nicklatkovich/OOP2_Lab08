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
    public partial class AddAnimalForm : Form {

        public AddAnimalForm(Animal animal) {
            InitializeComponent( );
            AnimalKindForm = new AnimalKindForm(this);
            this.Animal = animal;
            TextBoxNameAdd.BackColor = Program.ErrorBackColor;
            TextBoxAddAge.BackColor = Program.ErrorBackColor;
            DateTimePickerAdd.Value = DateTime.Now;
            TextBoxAddPerson1Name.BackColor = Program.ErrorBackColor;
            TextBoxAddPerson2Name.BackColor = Program.ErrorBackColor;
        }

        bool NameError = true;
        bool AgeError = true;
        bool RBError = true;
        bool TypeError = true;
        bool ClassError = true;
        bool DetachmentError = true;
        bool Name1stError = true;
        bool Name2ndError = true;

        public Animal Animal;
        private HabitatsForm HabitatsForm;
        private AnimalKindForm AnimalKindForm;

        private void ButtonKindEdit_Click(Object sender, EventArgs e) {
            AnimalKindForm = new AnimalKindForm(this);
            AnimalKindForm.Show( );
            AnimalKindForm.Focus( );
        }

        private void ButtonEditHabitats_Click(Object sender, EventArgs e) {
            HabitatsForm = new HabitatsForm(this);
            HabitatsForm.Show( );
            HabitatsForm.Focus( );
        }

        private void ButtonConfirmAnimalAddition_Click(Object sender, EventArgs e) {
            Program.MainForm.Animals.Add(Animal);
            Program.MainForm.RefreshZooPresenter( );
            Program.MainForm.Focus( );
            this.Close( );
        }

        private void TextBoxNameAdd_TextChanged(Object sender, EventArgs e) {
            if (TextBoxNameAdd.Text.Length > 0) {
                Animal.Name = TextBoxNameAdd.Text;
                NameError = false;
                TextBoxNameAdd.BackColor = Program.NormalBackColor;
            } else {
                NameError = true;
                TextBoxNameAdd.BackColor = Program.ErrorBackColor;
            }
        }

        private void TextBoxAddAge_TextChanged(Object sender, EventArgs e) {
            string text = TextBoxAddAge.Text;
            uint age;
            if (uint.TryParse(text, out age)) {
                Animal.Age = age;
                AgeError = false;
                TextBoxAddAge.BackColor = Program.NormalBackColor;
            } else {
                AgeError = true;
                TextBoxAddAge.BackColor = Program.ErrorBackColor;
            }
        }

        private void RadioButtonIsIn_CheckedChanged(Object sender, EventArgs e) {
            this.LblRB.ForeColor = Color.White;
            RBError = false;
            Animal.IsInRedBook = RadioButtonIsIn.Checked;
        }

        private void LabelType_TextChanged(Object sender, EventArgs e) {
            if (LabelType.Text.Length > 0) {
                LabelTypeT.ForeColor = Color.White;
                TypeError = false;
                Animal.Type = LabelType.Text;
            } else {
                LabelTypeT.ForeColor = Color.Red;
                TypeError = true;
            }
        }

        private void LabelClass_TextChanged(Object sender, EventArgs e) {
            if (LabelClass.Text.Length > 0) {
                LabelClassT.ForeColor = Color.White;
                ClassError = false;
                Animal.Class = LabelClass.Text;
            } else {
                LabelClassT.ForeColor = Color.Red;
                ClassError = true;
            }
        }

        private void LabelDetachment_TextChanged(Object sender, EventArgs e) {
            if (LabelDetachment.Text.Length > 0) {
                LabelDetachmentT.ForeColor = Color.White;
                DetachmentError = false;
                Animal.Detachment = LabelDetachment.Text;
            } else {
                LabelDetachmentT.ForeColor = Color.Red;
                DetachmentError = true;
            }
        }

        private void TextBoxAddPerson1Name_TextChanged(Object sender, EventArgs e) {
            if (TextBoxAddPerson1Name.Text.Length > 0) {
                TextBoxAddPerson1Name.BackColor = Program.NormalBackColor;
                Name1stError = false;
                Animal.Bailee.FirstName = TextBoxAddPerson1Name.Text;
            } else {
                TextBoxAddPerson1Name.BackColor = Program.ErrorBackColor;
                Name1stError = true;
            }
        }

        private void TextBoxAddPerson2Name_TextChanged(Object sender, EventArgs e) {
            if (TextBoxAddPerson2Name.Text.Length > 0) {
                TextBoxAddPerson2Name.BackColor = Program.NormalBackColor;
                Name2ndError = false;
                Animal.Bailee.LastName = TextBoxAddPerson2Name.Text;
            } else {
                TextBoxAddPerson2Name.BackColor = Program.ErrorBackColor;
                Name2ndError = true;
            }
        }

        private void TextBoxAddDescription_TextChanged(Object sender, EventArgs e) {
            Animal.Description = TextBoxAddDescription.Text;
        }

        private void DateTimePickerAdd_ValueChanged(Object sender, EventArgs e) {
            Animal.ReceiptDate = DateTimePickerAdd.Value;
        }
    }
}
