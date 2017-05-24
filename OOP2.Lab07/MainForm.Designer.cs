using System;
using System.Drawing;

namespace OOP2.Lab07 {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAddAnimal = new System.Windows.Forms.Button();
            this.ZooPresenter = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZooPresenter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoo";
            // 
            // ButtonAddAnimal
            // 
            this.ButtonAddAnimal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddAnimal.Location = new System.Drawing.Point(12, 116);
            this.ButtonAddAnimal.Name = "ButtonAddAnimal";
            this.ButtonAddAnimal.Size = new System.Drawing.Size(172, 32);
            this.ButtonAddAnimal.TabIndex = 2;
            this.ButtonAddAnimal.Text = "Добавить";
            this.ButtonAddAnimal.UseVisualStyleBackColor = true;
            this.ButtonAddAnimal.Click += new System.EventHandler(this.ButtonAddAnimal_Click);
            // 
            // ZooPresenter
            // 
            this.ZooPresenter.AllowUserToAddRows = false;
            this.ZooPresenter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.ZooPresenter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ZooPresenter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ZooPresenter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ZooPresenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ZooPresenter.DefaultCellStyle = dataGridViewCellStyle4;
            this.ZooPresenter.Location = new System.Drawing.Point(196, 50);
            this.ZooPresenter.MultiSelect = false;
            this.ZooPresenter.Name = "ZooPresenter";
            this.ZooPresenter.ReadOnly = true;
            this.ZooPresenter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ZooPresenter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ZooPresenter.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZooPresenter.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Lime;
            this.ZooPresenter.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.ZooPresenter.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.ZooPresenter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ZooPresenter.Size = new System.Drawing.Size(736, 539);
            this.ZooPresenter.TabIndex = 3;
            this.ZooPresenter.SelectionChanged += new System.EventHandler(this.ZooPresenter_SelectionChanged);
            this.ZooPresenter.Sorted += new System.EventHandler(this.ZooPresenter_Sorted);
            this.ZooPresenter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ZooPresenter_MouseDoubleClick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRefresh.Location = new System.Drawing.Point(760, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(172, 32);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Обновить";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSave.Location = new System.Drawing.Point(12, 225);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(172, 32);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLoad.Location = new System.Drawing.Point(12, 263);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(172, 32);
            this.BtnLoad.TabIndex = 6;
            this.BtnLoad.Text = "Загрузить";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEdit.Location = new System.Drawing.Point(12, 154);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(172, 32);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.ZooPresenter);
            this.Controls.Add(this.ButtonAddAnimal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo";
            ((System.ComponentModel.ISupportInitialize)(this.ZooPresenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAddAnimal;
        public System.Windows.Forms.DataGridView ZooPresenter;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnEdit;
    }
}

