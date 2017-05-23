namespace OOP2.Lab07 {
    partial class AnimalKindForm {
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
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelDetachment = new System.Windows.Forms.Label();
            this.ComboBoxClass = new System.Windows.Forms.ComboBox();
            this.ComboBoxDetachment = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.MaximumSize = new System.Drawing.Size(512, 26);
            this.label2.MinimumSize = new System.Drawing.Size(512, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Животного: [Animal.Name]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxType.ForeColor = System.Drawing.Color.White;
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Location = new System.Drawing.Point(12, 168);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(236, 33);
            this.ComboBoxType.TabIndex = 3;
            this.ComboBoxType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelClass.ForeColor = System.Drawing.Color.White;
            this.LabelClass.Location = new System.Drawing.Point(12, 204);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(63, 26);
            this.LabelClass.TabIndex = 6;
            this.LabelClass.Text = "Класс";
            this.LabelClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDetachment
            // 
            this.LabelDetachment.AutoSize = true;
            this.LabelDetachment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDetachment.ForeColor = System.Drawing.Color.White;
            this.LabelDetachment.Location = new System.Drawing.Point(7, 269);
            this.LabelDetachment.Name = "LabelDetachment";
            this.LabelDetachment.Size = new System.Drawing.Size(67, 26);
            this.LabelDetachment.TabIndex = 7;
            this.LabelDetachment.Text = "Отряд";
            this.LabelDetachment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxClass
            // 
            this.ComboBoxClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ComboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxClass.ForeColor = System.Drawing.Color.White;
            this.ComboBoxClass.FormattingEnabled = true;
            this.ComboBoxClass.Location = new System.Drawing.Point(12, 233);
            this.ComboBoxClass.Name = "ComboBoxClass";
            this.ComboBoxClass.Size = new System.Drawing.Size(236, 33);
            this.ComboBoxClass.TabIndex = 8;
            this.ComboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClasses_SelectedIndexChanged);
            // 
            // ComboBoxDetachment
            // 
            this.ComboBoxDetachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ComboBoxDetachment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDetachment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxDetachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxDetachment.ForeColor = System.Drawing.Color.White;
            this.ComboBoxDetachment.FormattingEnabled = true;
            this.ComboBoxDetachment.Location = new System.Drawing.Point(12, 298);
            this.ComboBoxDetachment.Name = "ComboBoxDetachment";
            this.ComboBoxDetachment.Size = new System.Drawing.Size(236, 33);
            this.ComboBoxDetachment.TabIndex = 9;
            this.ComboBoxDetachment.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDetachments_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(280, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnimalKindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(554, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ComboBoxDetachment);
            this.Controls.Add(this.ComboBoxClass);
            this.Controls.Add(this.LabelDetachment);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnimalKindForm";
            this.Text = "Animal Kind";
            this.Load += new System.EventHandler(this.AnimalKindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label LabelDetachment;
        private System.Windows.Forms.ComboBox ComboBoxClass;
        private System.Windows.Forms.ComboBox ComboBoxDetachment;
        private System.Windows.Forms.Button button1;
    }
}