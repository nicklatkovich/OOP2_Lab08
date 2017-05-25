using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OOP2.Lab08 {
    public partial class MainForm : Form {
        public MainForm( ) {
            InitializeComponent( );
            Load += MainForm_Load;
            ZooPresenter.Columns.Add("Animal", "Животное");
            ZooPresenter.Columns["Animal"].Visible = false;
            ZooPresenter.Columns.Add("Name", "Название");
            ZooPresenter.Columns.Add("Age", "Возраст");
            ZooPresenter.Columns.Add("RedBook", "Красная книга");
            ZooPresenter.Columns.Add("Type", "Тип");
            ZooPresenter.Columns["Type"].Visible = false;
            ZooPresenter.Columns.Add("Class", "Класс");
            ZooPresenter.Columns["Class"].Visible = false;
            ZooPresenter.Columns.Add("Detachment", "Отряд");
            ZooPresenter.Columns.Add("ReceiptDate", "Дата поступления");
            ZooPresenter.Columns.Add("HabitatArea", "Ареал");
            ZooPresenter.Columns.Add("Bailee", "Куратор");
        }

        public List<Animal> Animals = new List<Animal>( );

        private EditAnimalForm AddAnimalForm;
        private AboutForm AboutForm = null;

        private void MainForm_Load(Object sender, EventArgs e) {
        }

        private void ButtonAddAnimal_Click(Object sender, EventArgs e) {
            if (AddAnimalForm == null || AddAnimalForm.IsDisposed) {
                AddAnimalForm = new EditAnimalForm(null);
            }
            AddAnimalForm.Show( );
            AddAnimalForm.Focus( );
            AddAnimalForm.LabelClass.Text = AddAnimalForm.LabelType.Text = AddAnimalForm.LabelDetachment.Text = "";
        }

        private void groupBox2_Enter(Object sender, EventArgs e) {

        }

        private void ButtonConfirmAnimalAddition_Click(Object sender, EventArgs e) {

        }

        private void BtnRefresh_Click(Object sender, EventArgs e) {
            RefreshZooPresenter( );
        }

        public void RefreshZooPresenter( ) {
            ZooPresenter.Rows.Clear( );
            foreach (var a in Animals) {
                ZooPresenter.Rows.Add(new object[ ] {
                    a,
                    a.Name,
                    a.Age,
                    a.IsInRedBook,
                    a.Type,
                    a.Class,
                    a.Detachment,
                    a.ReceiptDate,
                    a.GetCommonHabitatsArea( ),
                    a.Bailee,
                });
            }
            ZooPresenter.ClearSelection( );
        }

        private void BtnSave_Click(Object sender, EventArgs e) {
            SaveZoo( );
        }

        private void SaveZoo( ) {
            SaveFileDialog sfd = new SaveFileDialog( );
            sfd.Filter = "Zoo Data Base (*zdb)|*.zdb|Zoo eXtensible Markup (*zxm)|*.zxm";
            if (sfd.ShowDialog( ) == DialogResult.OK) {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate)) {
                    if (sfd.FilterIndex == 0) {
                        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal[ ]));
                        jsonFormatter.WriteObject(fs, Animals.ToArray( ));
                    } else {
                        XmlSerializer formatter = new XmlSerializer(typeof(Animal[ ]));
                        formatter.Serialize(fs, Animals.ToArray( ));
                    }
                }
            }
        }

        private void BtnLoad_Click(Object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog( );
            ofd.Filter = "Zoo Data Base (*zdb)|*.zdb|Zoo eXtensible Markup (*zxm)|*.zxm";
            if (ofd.ShowDialog( ) == DialogResult.OK) {
                if (ofd.FilterIndex == 0) {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal[ ]));
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate)) {
                        Animals = new List<Animal>((Animal[ ])jsonFormatter.ReadObject(fs));
                    }
                } else {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal[ ]));
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate)) {
                        Animals = new List<Animal>((Animal[ ])jsonFormatter.ReadObject(fs));
                    }
                }
            }
            RefreshZooPresenter( );
        }

        private void ZooPresenter_MouseDoubleClick(Object sender, MouseEventArgs e) {
        }

        private void ZooPresenter_Sorted(Object sender, EventArgs e) {
            ZooPresenter.ClearSelection( );
        }

        private void ZooPresenter_SelectionChanged(Object sender, EventArgs e) {
            BtnEdit.Visible = ZooPresenter.SelectedRows.Count == 1;
        }

        private void BtnEdit_Click(Object sender, EventArgs e) {
            Animal animal = ZooPresenter.SelectedRows[0].Cells[0].Value as Animal;
            if (AddAnimalForm == null || AddAnimalForm.IsDisposed) {
                AddAnimalForm = new EditAnimalForm(animal);
            }
            ZooPresenter.Enabled = false;
            AddAnimalForm.Show( );
            AddAnimalForm.Focus( );
            //AddAnimalForm.LabelClass.Text = AddAnimalForm.LabelType.Text = AddAnimalForm.LabelDetachment.Text = "";
        }

        private void MenuSortByDate_Click(Object sender, EventArgs e) {
            SortBy("ReceiptDate");
        }

        private void MenuSortByBailee_Click(Object sender, EventArgs e) {
            SortBy("Bailee");
        }

        public void SortBy(string columnName) {
            if (ZooPresenter.SortedColumn != ZooPresenter.Columns[columnName] || ZooPresenter.SortOrder == SortOrder.Descending) {
                ZooPresenter.Sort(ZooPresenter.Columns[columnName], System.ComponentModel.ListSortDirection.Ascending);
            } else {
                ZooPresenter.Sort(ZooPresenter.Columns[columnName], System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void MenuSave_Click(Object sender, EventArgs e) {
            SaveZoo( );
        }

        private void MenuAbout_Click(Object sender, EventArgs e) {
            if (AboutForm == null || AboutForm.IsDisposed) {
                AboutForm = new AboutForm( );
            }
            AboutForm.Show( );
            AboutForm.Focus( );
        }
    }
}
