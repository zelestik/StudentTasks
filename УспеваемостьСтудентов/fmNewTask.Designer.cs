namespace УспеваемостьСтудентов
{
    partial class fmNewTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laSubject = new System.Windows.Forms.Label();
            this.laDescription = new System.Windows.Forms.Label();
            this.laType = new System.Windows.Forms.Label();
            this.laExpDate = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbIsGroup = new System.Windows.Forms.CheckBox();
            this.dateTimePickerExpiration = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // laSubject
            // 
            this.laSubject.AutoSize = true;
            this.laSubject.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSubject.Location = new System.Drawing.Point(10, 9);
            this.laSubject.Name = "laSubject";
            this.laSubject.Size = new System.Drawing.Size(95, 25);
            this.laSubject.TabIndex = 0;
            this.laSubject.Text = "Предмет";
            // 
            // laDescription
            // 
            this.laDescription.AutoSize = true;
            this.laDescription.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laDescription.Location = new System.Drawing.Point(10, 46);
            this.laDescription.Name = "laDescription";
            this.laDescription.Size = new System.Drawing.Size(111, 25);
            this.laDescription.TabIndex = 1;
            this.laDescription.Text = "Описание";
            // 
            // laType
            // 
            this.laType.AutoSize = true;
            this.laType.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laType.Location = new System.Drawing.Point(10, 134);
            this.laType.Name = "laType";
            this.laType.Size = new System.Drawing.Size(119, 25);
            this.laType.TabIndex = 2;
            this.laType.Text = "Тип задачи";
            // 
            // laExpDate
            // 
            this.laExpDate.AutoSize = true;
            this.laExpDate.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laExpDate.Location = new System.Drawing.Point(12, 170);
            this.laExpDate.Name = "laExpDate";
            this.laExpDate.Size = new System.Drawing.Size(146, 25);
            this.laExpDate.TabIndex = 3;
            this.laExpDate.Text = "Выполнить до";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(185, 9);
            this.txtSubject.MaxLength = 32;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(185, 27);
            this.txtSubject.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(185, 46);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 81);
            this.txtDescription.TabIndex = 5;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.White;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.Location = new System.Drawing.Point(185, 133);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(185, 28);
            this.cbType.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Gilroy ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Location = new System.Drawing.Point(0, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(382, 63);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.buAdd_Click);
            // 
            // cbIsGroup
            // 
            this.cbIsGroup.AutoSize = true;
            this.cbIsGroup.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbIsGroup.Location = new System.Drawing.Point(17, 209);
            this.cbIsGroup.Name = "cbIsGroup";
            this.cbIsGroup.Size = new System.Drawing.Size(206, 29);
            this.cbIsGroup.TabIndex = 10;
            this.cbIsGroup.Text = "Групповая задача";
            this.cbIsGroup.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerExpiration
            // 
            this.dateTimePickerExpiration.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerExpiration.Location = new System.Drawing.Point(185, 170);
            this.dateTimePickerExpiration.Name = "dateTimePickerExpiration";
            this.dateTimePickerExpiration.Size = new System.Drawing.Size(185, 28);
            this.dateTimePickerExpiration.TabIndex = 11;
            // 
            // fmNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.dateTimePickerExpiration);
            this.Controls.Add(this.cbIsGroup);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.laExpDate);
            this.Controls.Add(this.laType);
            this.Controls.Add(this.laDescription);
            this.Controls.Add(this.laSubject);
            this.Font = new System.Drawing.Font("Gilroy ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "fmNewTask";
            this.Opacity = 0.95D;
            this.Text = "Новая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laSubject;
        private System.Windows.Forms.Label laDescription;
        private System.Windows.Forms.Label laType;
        private System.Windows.Forms.Label laExpDate;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbIsGroup;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiration;
    }
}