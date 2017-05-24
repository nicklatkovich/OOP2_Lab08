namespace OOP2.Lab07 {
    partial class EditAnimalForm {
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
            this.ButtonHabitatsEdit = new System.Windows.Forms.Button();
            this.LabelTypeT = new System.Windows.Forms.Label();
            this.LabelDetachment = new System.Windows.Forms.Label();
            this.LabelClassT = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.TextBoxAddPerson2Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxAddPerson1Name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelHabitatsNumber = new System.Windows.Forms.Label();
            this.LabelHabitatsArea = new System.Windows.Forms.Label();
            this.ButtonEditHabitats = new System.Windows.Forms.Button();
            this.LabelDetachmentT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonConfirmAnimalAddition = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioButtonIsNotIn = new System.Windows.Forms.RadioButton();
            this.RadioButtonIsIn = new System.Windows.Forms.RadioButton();
            this.LblRB = new System.Windows.Forms.Label();
            this.TextBoxAddAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxAddDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonHabitatsEdit
            // 
            this.ButtonHabitatsEdit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHabitatsEdit.ForeColor = System.Drawing.Color.Black;
            this.ButtonHabitatsEdit.Location = new System.Drawing.Point(111, 97);
            this.ButtonHabitatsEdit.Name = "ButtonHabitatsEdit";
            this.ButtonHabitatsEdit.Size = new System.Drawing.Size(119, 32);
            this.ButtonHabitatsEdit.TabIndex = 4;
            this.ButtonHabitatsEdit.Text = "Изменить";
            this.ButtonHabitatsEdit.UseVisualStyleBackColor = true;
            this.ButtonHabitatsEdit.Click += new System.EventHandler(this.ButtonKindEdit_Click);
            // 
            // LabelTypeT
            // 
            this.LabelTypeT.AutoSize = true;
            this.LabelTypeT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTypeT.ForeColor = System.Drawing.Color.White;
            this.LabelTypeT.Location = new System.Drawing.Point(6, 17);
            this.LabelTypeT.Name = "LabelTypeT";
            this.LabelTypeT.Size = new System.Drawing.Size(44, 26);
            this.LabelTypeT.TabIndex = 12;
            this.LabelTypeT.Text = "Тип";
            // 
            // LabelDetachment
            // 
            this.LabelDetachment.AutoSize = true;
            this.LabelDetachment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDetachment.ForeColor = System.Drawing.Color.White;
            this.LabelDetachment.Location = new System.Drawing.Point(79, 68);
            this.LabelDetachment.Name = "LabelDetachment";
            this.LabelDetachment.Size = new System.Drawing.Size(23, 26);
            this.LabelDetachment.TabIndex = 17;
            this.LabelDetachment.Text = "q";
            this.LabelDetachment.TextChanged += new System.EventHandler(this.LabelDetachment_TextChanged);
            // 
            // LabelClassT
            // 
            this.LabelClassT.AutoSize = true;
            this.LabelClassT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelClassT.ForeColor = System.Drawing.Color.White;
            this.LabelClassT.Location = new System.Drawing.Point(6, 43);
            this.LabelClassT.Name = "LabelClassT";
            this.LabelClassT.Size = new System.Drawing.Size(63, 26);
            this.LabelClassT.TabIndex = 13;
            this.LabelClassT.Text = "Класс";
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelClass.ForeColor = System.Drawing.Color.White;
            this.LabelClass.Location = new System.Drawing.Point(79, 43);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(23, 26);
            this.LabelClass.TabIndex = 16;
            this.LabelClass.Text = "q";
            this.LabelClass.TextChanged += new System.EventHandler(this.LabelClass_TextChanged);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelType.ForeColor = System.Drawing.Color.White;
            this.LabelType.Location = new System.Drawing.Point(79, 17);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(23, 26);
            this.LabelType.TabIndex = 15;
            this.LabelType.Text = "q";
            this.LabelType.TextChanged += new System.EventHandler(this.LabelType_TextChanged);
            // 
            // TextBoxAddPerson2Name
            // 
            this.TextBoxAddPerson2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxAddPerson2Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddPerson2Name.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxAddPerson2Name.Location = new System.Drawing.Point(125, 68);
            this.TextBoxAddPerson2Name.Name = "TextBoxAddPerson2Name";
            this.TextBoxAddPerson2Name.Size = new System.Drawing.Size(172, 27);
            this.TextBoxAddPerson2Name.TabIndex = 23;
            this.TextBoxAddPerson2Name.TextChanged += new System.EventHandler(this.TextBoxAddPerson2Name_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(22, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 26);
            this.label14.TabIndex = 22;
            this.label14.Text = "Фамилия";
            // 
            // TextBoxAddPerson1Name
            // 
            this.TextBoxAddPerson1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxAddPerson1Name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddPerson1Name.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxAddPerson1Name.Location = new System.Drawing.Point(125, 33);
            this.TextBoxAddPerson1Name.Name = "TextBoxAddPerson1Name";
            this.TextBoxAddPerson1Name.Size = new System.Drawing.Size(172, 27);
            this.TextBoxAddPerson1Name.TabIndex = 21;
            this.TextBoxAddPerson1Name.TextChanged += new System.EventHandler(this.TextBoxAddPerson1Name_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(22, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 26);
            this.label13.TabIndex = 20;
            this.label13.Text = "Имя";
            // 
            // LabelHabitatsNumber
            // 
            this.LabelHabitatsNumber.AutoSize = true;
            this.LabelHabitatsNumber.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHabitatsNumber.ForeColor = System.Drawing.Color.White;
            this.LabelHabitatsNumber.Location = new System.Drawing.Point(55, 25);
            this.LabelHabitatsNumber.Name = "LabelHabitatsNumber";
            this.LabelHabitatsNumber.Size = new System.Drawing.Size(66, 26);
            this.LabelHabitatsNumber.TabIndex = 21;
            this.LabelHabitatsNumber.Text = "Зон: 0";
            // 
            // LabelHabitatsArea
            // 
            this.LabelHabitatsArea.AutoSize = true;
            this.LabelHabitatsArea.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHabitatsArea.ForeColor = System.Drawing.Color.White;
            this.LabelHabitatsArea.Location = new System.Drawing.Point(55, 58);
            this.LabelHabitatsArea.Name = "LabelHabitatsArea";
            this.LabelHabitatsArea.Size = new System.Drawing.Size(159, 26);
            this.LabelHabitatsArea.TabIndex = 22;
            this.LabelHabitatsArea.Text = "Площадь: 0 км2";
            // 
            // ButtonEditHabitats
            // 
            this.ButtonEditHabitats.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditHabitats.ForeColor = System.Drawing.Color.Black;
            this.ButtonEditHabitats.Location = new System.Drawing.Point(95, 97);
            this.ButtonEditHabitats.Name = "ButtonEditHabitats";
            this.ButtonEditHabitats.Size = new System.Drawing.Size(126, 32);
            this.ButtonEditHabitats.TabIndex = 18;
            this.ButtonEditHabitats.Text = "Изменить";
            this.ButtonEditHabitats.UseVisualStyleBackColor = true;
            this.ButtonEditHabitats.Click += new System.EventHandler(this.ButtonEditHabitats_Click);
            // 
            // LabelDetachmentT
            // 
            this.LabelDetachmentT.AutoSize = true;
            this.LabelDetachmentT.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDetachmentT.ForeColor = System.Drawing.Color.White;
            this.LabelDetachmentT.Location = new System.Drawing.Point(6, 68);
            this.LabelDetachmentT.Name = "LabelDetachmentT";
            this.LabelDetachmentT.Size = new System.Drawing.Size(67, 26);
            this.LabelDetachmentT.TabIndex = 14;
            this.LabelDetachmentT.Text = "Отряд";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelHabitatsNumber);
            this.groupBox1.Controls.Add(this.LabelHabitatsArea);
            this.groupBox1.Controls.Add(this.ButtonEditHabitats);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(413, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 142);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ареал обитания";
            // 
            // ButtonConfirmAnimalAddition
            // 
            this.ButtonConfirmAnimalAddition.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConfirmAnimalAddition.ForeColor = System.Drawing.Color.Black;
            this.ButtonConfirmAnimalAddition.Location = new System.Drawing.Point(442, 475);
            this.ButtonConfirmAnimalAddition.Name = "ButtonConfirmAnimalAddition";
            this.ButtonConfirmAnimalAddition.Size = new System.Drawing.Size(235, 68);
            this.ButtonConfirmAnimalAddition.TabIndex = 38;
            this.ButtonConfirmAnimalAddition.Text = "Добавить";
            this.ButtonConfirmAnimalAddition.UseVisualStyleBackColor = true;
            this.ButtonConfirmAnimalAddition.Click += new System.EventHandler(this.ButtonConfirmAnimalAddition_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxAddPerson2Name);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TextBoxAddPerson1Name);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(40, 451);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 122);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ответственное лицо";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonHabitatsEdit);
            this.groupBox2.Controls.Add(this.LabelTypeT);
            this.groupBox2.Controls.Add(this.LabelDetachment);
            this.groupBox2.Controls.Add(this.LabelClassT);
            this.groupBox2.Controls.Add(this.LabelClass);
            this.groupBox2.Controls.Add(this.LabelDetachmentT);
            this.groupBox2.Controls.Add(this.LabelType);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(40, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 142);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип животного";
            // 
            // DateTimePickerAdd
            // 
            this.DateTimePickerAdd.CalendarForeColor = System.Drawing.Color.White;
            this.DateTimePickerAdd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DateTimePickerAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePickerAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerAdd.Location = new System.Drawing.Point(597, 91);
            this.DateTimePickerAdd.Name = "DateTimePickerAdd";
            this.DateTimePickerAdd.Size = new System.Drawing.Size(96, 27);
            this.DateTimePickerAdd.TabIndex = 34;
            this.DateTimePickerAdd.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerAdd.ValueChanged += new System.EventHandler(this.DateTimePickerAdd_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(556, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 26);
            this.label6.TabIndex = 33;
            this.label6.Text = "Дата поступления";
            // 
            // RadioButtonIsNotIn
            // 
            this.RadioButtonIsNotIn.AutoSize = true;
            this.RadioButtonIsNotIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonIsNotIn.ForeColor = System.Drawing.Color.White;
            this.RadioButtonIsNotIn.Location = new System.Drawing.Point(561, 222);
            this.RadioButtonIsNotIn.Name = "RadioButtonIsNotIn";
            this.RadioButtonIsNotIn.Size = new System.Drawing.Size(51, 23);
            this.RadioButtonIsNotIn.TabIndex = 32;
            this.RadioButtonIsNotIn.Text = "Нет";
            this.RadioButtonIsNotIn.UseVisualStyleBackColor = true;
            this.RadioButtonIsNotIn.CheckedChanged += new System.EventHandler(this.RadioButtonIsIn_CheckedChanged);
            // 
            // RadioButtonIsIn
            // 
            this.RadioButtonIsIn.AutoSize = true;
            this.RadioButtonIsIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonIsIn.ForeColor = System.Drawing.Color.White;
            this.RadioButtonIsIn.Location = new System.Drawing.Point(561, 204);
            this.RadioButtonIsIn.Name = "RadioButtonIsIn";
            this.RadioButtonIsIn.Size = new System.Drawing.Size(46, 23);
            this.RadioButtonIsIn.TabIndex = 31;
            this.RadioButtonIsIn.Text = "Да";
            this.RadioButtonIsIn.UseVisualStyleBackColor = true;
            this.RadioButtonIsIn.CheckedChanged += new System.EventHandler(this.RadioButtonIsIn_CheckedChanged);
            // 
            // LblRB
            // 
            this.LblRB.AutoSize = true;
            this.LblRB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRB.ForeColor = System.Drawing.Color.Red;
            this.LblRB.Location = new System.Drawing.Point(556, 175);
            this.LblRB.Name = "LblRB";
            this.LblRB.Size = new System.Drawing.Size(140, 26);
            this.LblRB.TabIndex = 30;
            this.LblRB.Text = "Красная книга";
            // 
            // TextBoxAddAge
            // 
            this.TextBoxAddAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxAddAge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddAge.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxAddAge.Location = new System.Drawing.Point(431, 45);
            this.TextBoxAddAge.Name = "TextBoxAddAge";
            this.TextBoxAddAge.Size = new System.Drawing.Size(84, 27);
            this.TextBoxAddAge.TabIndex = 29;
            this.TextBoxAddAge.TextChanged += new System.EventHandler(this.TextBoxAddAge_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Возраст";
            // 
            // TextBoxAddDescription
            // 
            this.TextBoxAddDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxAddDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddDescription.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxAddDescription.Location = new System.Drawing.Point(40, 120);
            this.TextBoxAddDescription.Multiline = true;
            this.TextBoxAddDescription.Name = "TextBoxAddDescription";
            this.TextBoxAddDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxAddDescription.Size = new System.Drawing.Size(475, 140);
            this.TextBoxAddDescription.TabIndex = 27;
            this.TextBoxAddDescription.TextChanged += new System.EventHandler(this.TextBoxAddDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(225, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Описание";
            // 
            // TextBoxNameAdd
            // 
            this.TextBoxNameAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TextBoxNameAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNameAdd.ForeColor = System.Drawing.Color.Lime;
            this.TextBoxNameAdd.Location = new System.Drawing.Point(117, 45);
            this.TextBoxNameAdd.Name = "TextBoxNameAdd";
            this.TextBoxNameAdd.Size = new System.Drawing.Size(220, 27);
            this.TextBoxNameAdd.TabIndex = 25;
            this.TextBoxNameAdd.TextChanged += new System.EventHandler(this.TextBoxNameAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "Название";
            // 
            // EditAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(739, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonConfirmAnimalAddition);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DateTimePickerAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RadioButtonIsNotIn);
            this.Controls.Add(this.RadioButtonIsIn);
            this.Controls.Add(this.LblRB);
            this.Controls.Add(this.TextBoxAddAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxAddDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxNameAdd);
            this.Controls.Add(this.label2);
            this.Name = "EditAnimalForm";
            this.Text = "Редактор животного";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAnimalForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonHabitatsEdit;
        private System.Windows.Forms.Label LabelTypeT;
        public System.Windows.Forms.Label LabelDetachment;
        private System.Windows.Forms.Label LabelClassT;
        public System.Windows.Forms.Label LabelClass;
        public System.Windows.Forms.Label LabelType;
        public System.Windows.Forms.TextBox TextBoxAddPerson2Name;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox TextBoxAddPerson1Name;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label LabelHabitatsNumber;
        public System.Windows.Forms.Label LabelHabitatsArea;
        private System.Windows.Forms.Button ButtonEditHabitats;
        private System.Windows.Forms.Label LabelDetachmentT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonConfirmAnimalAddition;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker DateTimePickerAdd;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton RadioButtonIsNotIn;
        public System.Windows.Forms.RadioButton RadioButtonIsIn;
        private System.Windows.Forms.Label LblRB;
        public System.Windows.Forms.TextBox TextBoxAddAge;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TextBoxAddDescription;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TextBoxNameAdd;
        private System.Windows.Forms.Label label2;
    }
}