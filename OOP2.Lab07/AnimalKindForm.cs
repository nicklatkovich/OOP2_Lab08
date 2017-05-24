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
    public partial class AnimalKindForm : Form {

        private static Tree<string> Animal = new Tree<string>("Animal", null);

        static AnimalKindForm( ) {
            Animal.Add("Простейшее");
            Animal.Add("Губка");
            Animal.Add("Кишечнополостное");
            Animal.Add("Червь");
            Animal.Add("Моллюск");
            Tree<string> arthropods = Animal.Add("Членистоногое");
            arthropods.Add("Ракообразное");
            arthropods.Add("Паукообразное");
            arthropods.Add("Насекомое");
            Tree<string> chordate = Animal.Add("Хордовое");
            Tree<string> mammal = chordate.Add("Млекопитающее");
            mammal.Add("Насекомоядное");
            mammal.Add("Рукокрылое");
            mammal.Add("Грызун");
            mammal.Add("Хищное");
            mammal.Add("Китообразное");
            mammal.Add("Парнокопытное");
            mammal.Add("Хаботное");
            mammal.Add("Примыт");
            chordate.Add("Птица");
            chordate.Add("Пресмыкающееся");
            chordate.Add("Земноводное");
            chordate.Add("Рыба");
        }

        public AnimalKindForm(AddAnimalForm addAnimalForm) {
            this.AddAnimalForm = addAnimalForm;
            InitializeComponent( );
        }

        private AddAnimalForm AddAnimalForm;

        private void button1_Click(Object sender, EventArgs e) {
            this.Visible = false;
        }

        private void label2_Click(Object sender, EventArgs e) {

        }

        private void AnimalKindForm_Load(Object sender, EventArgs e) {
            Tree<string>[ ] types_tree = Animal.Children;
            for (UInt32 i = 0; i < types_tree.Length; i++) {
                this.ComboBoxType.Items.Add(types_tree[i].Data);
            }
            ComboBoxClass.Visible = false;
            LabelClass.Visible = false;
            ComboBoxDetachment.Visible = false;
            LabelDetachment.Visible = false;
            string type = AddAnimalForm.LabelType.Text;
            string @class = AddAnimalForm.LabelClass.Text;
            string detachment = AddAnimalForm.LabelDetachment.Text;
            ComboBoxType.SelectedIndex = ComboBoxType.Items.IndexOf(type);
            ComboBoxClass.SelectedIndex = ComboBoxClass.Items.IndexOf(@class);
            ComboBoxDetachment.SelectedIndex = ComboBoxDetachment.Items.IndexOf(detachment);
        }

        private void ComboBoxType_SelectedIndexChanged(Object sender, EventArgs e) {
            if (ComboBoxType.SelectedIndex >= 0) {
                Tree<string>[ ] types_tree = Animal.Children;
                AddAnimalForm.LabelType.Text = types_tree[ComboBoxType.SelectedIndex].Data;
                Tree<string>[ ] classes_tree = types_tree[ComboBoxType.SelectedIndex].Children;
                if (classes_tree.Length == 0) {
                    ComboBoxClass.Visible = false;
                    LabelClass.Visible = false;
                } else {
                    ComboBoxClass.Visible = true;
                    LabelClass.Visible = true;
                    ComboBoxClass.Items.Clear( );
                    foreach (var a in classes_tree) {
                        ComboBoxClass.Items.Add(a.Data);
                    }
                }
                ComboBoxDetachment.Visible = false;
                LabelDetachment.Visible = false;
            } else {
                AddAnimalForm.LabelType.Text = "";
            }
            AddAnimalForm.LabelClass.Text = AddAnimalForm.LabelDetachment.Text = "";
            ComboBoxClass.SelectedIndex = -1;
            ComboBoxDetachment.SelectedIndex = -1;
        }

        private void ComboBoxClasses_SelectedIndexChanged(Object sender, EventArgs e) {
            if (ComboBoxClass.SelectedIndex >= 0) {
                Tree<string>[ ] types_tree = Animal.Children;
                Tree<string>[ ] classes_tree = types_tree[ComboBoxType.SelectedIndex].Children;
                AddAnimalForm.LabelClass.Text = classes_tree[ComboBoxClass.SelectedIndex].Data;
                Tree<string>[ ] detachments_tree = classes_tree[ComboBoxClass.SelectedIndex].Children;
                if (detachments_tree.Length == 0) {
                    LabelDetachment.Visible = false;
                    ComboBoxDetachment.Visible = false;
                } else {
                    LabelDetachment.Visible = true;
                    ComboBoxDetachment.Visible = true;
                    ComboBoxDetachment.Items.Clear( );
                    foreach (var a in detachments_tree) {
                        ComboBoxDetachment.Items.Add(a.Data);
                    }
                }
            } else {
                AddAnimalForm.LabelClass.Text = "";
            }
            AddAnimalForm.LabelDetachment.Text = "";
            ComboBoxDetachment.SelectedIndex = -1;
        }

        private void ComboBoxDetachments_SelectedIndexChanged(Object sender, EventArgs e) {
            if (ComboBoxDetachment.SelectedIndex >= 0) {
                AddAnimalForm.LabelDetachment.Text = ComboBoxDetachment.SelectedItem.ToString( );
            } else {
                AddAnimalForm.LabelDetachment.Text = "";
            }
        }
    }
}
