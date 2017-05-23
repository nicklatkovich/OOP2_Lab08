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
        public AddAnimalForm( ) {
            InitializeComponent( );
            AnimalKindForm = new AnimalKindForm(this);
            HabitatsForm = new HabitatsForm(this);
        }

        private HabitatsForm HabitatsForm;
        private AnimalKindForm AnimalKindForm;

        private void ButtonHabitatsEdit_Click(Object sender, EventArgs e) {
            AnimalKindForm.Show( );
            AnimalKindForm.Focus( );
        }

        private void ButtonEditHabitats_Click(Object sender, EventArgs e) {
            HabitatsForm.Show( );
            HabitatsForm.Focus( );
        }

        private void ButtonConfirmAnimalAddition_Click(Object sender, EventArgs e) {
            Animal animal = new Animal( );
            animal.Name = TextBoxNameAdd.Text;
            animal.Age = uint.Parse(TextBoxAddAge.Text);
            animal.Description = TextBoxAddDescription.Text;
            animal.IsInRedBook = RadioButtonIsIn.Checked;
            animal.Type = LabelType.Text;
            animal.Class = LabelClass.Text;
            animal.Detachment = LabelDetachment.Text;
            animal.Habitats = new List<Habitat>( );
            foreach (var a in HabitatsForm.ListBoxHabitats.Items) {
                if (a is Habitat) {
                    animal.Habitats.Add(a as Habitat);
                }
            }
            animal.Bailee = new Person(TextBoxAddPerson1Name.Text, TextBoxAddPerson2Name.Text);
            animal.ReceiptDate = DateTimePickerAdd.Value;
            Program.MainForm.Animals.Add(animal);
        }
    }
}
