using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace OOP2.Lab07 {
    public partial class MainForm : Form {
        public MainForm( ) {
            InitializeComponent( );
            Load += MainForm_Load;
            ZooPresenter.Columns.Add("Name", "Название");
            ZooPresenter.Columns.Add("Age", "Возраст");
            ZooPresenter.Columns.Add("RedBook", "Красная книга");
            ZooPresenter.Columns.Add("Type", "Тип");
            ZooPresenter.Columns.Add("Class", "Класс");
            ZooPresenter.Columns.Add("Detachment", "Отряд");
            ZooPresenter.Columns.Add("HabitatArea", "Ареал");
        }

        public List<Animal> Animals = new List<Animal>( );

        private AddAnimalForm AddAnimalForm = new AddAnimalForm( );

        private void MainForm_Load(Object sender, EventArgs e) {
        }

        private void ButtonAddAnimal_Click(Object sender, EventArgs e) {
            if (AddAnimalForm.IsDisposed) {
                AddAnimalForm = new AddAnimalForm( );
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
            ZooPresenter.Rows.Clear( );
            foreach (var a in Animals) {
                ZooPresenter.Rows.Add(new string[ ] {
                    a.Name,
                    a.Age.ToString( ),
                    a.IsInRedBook.ToString( ),
                    a.Type,
                    a.Class,
                    a.Detachment,
                    a.GetCommonHabitatsArea( ).ToString( ),
                });
            }
        }

        private void BtnSave_Click(Object sender, EventArgs e) {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal[ ]));
            SaveFileDialog sfd = new SaveFileDialog( );
            sfd.Filter = "Zoo Data Base (*zdb)|*.zdb";
            if (sfd.ShowDialog( ) == DialogResult.OK) {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate)) {
                    jsonFormatter.WriteObject(fs, Animals.ToArray( ));
                }
            }
        }

        private void BtnLoad_Click(Object sender, EventArgs e) {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal[ ]));
            OpenFileDialog ofd = new OpenFileDialog( );
            ofd.Filter = "Zoo Data Base (*zdb)|*.zdb";
            if (ofd.ShowDialog( ) == DialogResult.OK) {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate)) {
                    Animals = new List<Animal>((Animal[ ])jsonFormatter.ReadObject(fs));
                }
            }
        }
    }
}
