using System.Windows.Forms;

namespace OOP2.Lab07 {
    partial class HabitatsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxHabitats = new System.Windows.Forms.ListBox();
            this.GroupBoxEdit = new System.Windows.Forms.GroupBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxZen = new System.Windows.Forms.TextBox();
            this.TextBoxAz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ареал обитания";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 81);
            this.label2.MaximumSize = new System.Drawing.Size(340, 26);
            this.label2.MinimumSize = new System.Drawing.Size(340, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Животного: [Animal.Name]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListBoxHabitats
            // 
            this.ListBoxHabitats.BackColor = System.Drawing.Color.DimGray;
            this.ListBoxHabitats.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListBoxHabitats.ForeColor = System.Drawing.Color.Lime;
            this.ListBoxHabitats.FormattingEnabled = true;
            this.ListBoxHabitats.ItemHeight = 26;
            this.ListBoxHabitats.Items.AddRange(new object[] {
            "Добавить"});
            this.ListBoxHabitats.Location = new System.Drawing.Point(12, 142);
            this.ListBoxHabitats.Name = "ListBoxHabitats";
            this.ListBoxHabitats.Size = new System.Drawing.Size(265, 212);
            this.ListBoxHabitats.TabIndex = 2;
            this.ListBoxHabitats.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // GroupBoxEdit
            // 
            this.GroupBoxEdit.Controls.Add(this.ButtonDelete);
            this.GroupBoxEdit.Controls.Add(this.TextBoxArea);
            this.GroupBoxEdit.Controls.Add(this.label5);
            this.GroupBoxEdit.Controls.Add(this.TextBoxZen);
            this.GroupBoxEdit.Controls.Add(this.TextBoxAz);
            this.GroupBoxEdit.Controls.Add(this.label4);
            this.GroupBoxEdit.Controls.Add(this.label3);
            this.GroupBoxEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxEdit.ForeColor = System.Drawing.Color.White;
            this.GroupBoxEdit.Location = new System.Drawing.Point(283, 132);
            this.GroupBoxEdit.Name = "GroupBoxEdit";
            this.GroupBoxEdit.Size = new System.Drawing.Size(266, 222);
            this.GroupBoxEdit.TabIndex = 3;
            this.GroupBoxEdit.TabStop = false;
            this.GroupBoxEdit.Text = "Ареал обитания №[Habitat.ID]";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Black;
            this.ButtonDelete.Location = new System.Drawing.Point(29, 158);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(212, 48);
            this.ButtonDelete.TabIndex = 26;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxArea
            // 
            this.TextBoxArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxArea.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxArea.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxArea.Location = new System.Drawing.Point(108, 104);
            this.TextBoxArea.Name = "TextBoxArea";
            this.TextBoxArea.Size = new System.Drawing.Size(142, 33);
            this.TextBoxArea.TabIndex = 5;
            this.TextBoxArea.TextChanged += new System.EventHandler(this.TextBoxArea_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Площадь";
            // 
            // TextBoxZen
            // 
            this.TextBoxZen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxZen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxZen.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxZen.Location = new System.Drawing.Point(108, 65);
            this.TextBoxZen.Name = "TextBoxZen";
            this.TextBoxZen.Size = new System.Drawing.Size(142, 33);
            this.TextBoxZen.TabIndex = 3;
            this.TextBoxZen.TextChanged += new System.EventHandler(this.TextBoxZen_TextChanged);
            // 
            // TextBoxAz
            // 
            this.TextBoxAz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxAz.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAz.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxAz.Location = new System.Drawing.Point(108, 26);
            this.TextBoxAz.Name = "TextBoxAz";
            this.TextBoxAz.Size = new System.Drawing.Size(142, 33);
            this.TextBoxAz.TabIndex = 2;
            this.TextBoxAz.TextChanged += new System.EventHandler(this.TextBoxAz_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Долгота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Широта";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(159, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 63);
            this.button1.TabIndex = 25;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HabitatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(561, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBoxEdit);
            this.Controls.Add(this.ListBoxHabitats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HabitatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitats";
            this.GroupBoxEdit.ResumeLayout(false);
            this.GroupBoxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox ListBoxHabitats;
        private System.Windows.Forms.GroupBox GroupBoxEdit;
        private System.Windows.Forms.TextBox TextBoxAz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxZen;
        private System.Windows.Forms.Button button1;
        private Button ButtonDelete;
    }
}