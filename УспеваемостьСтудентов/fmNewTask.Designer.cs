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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buAdd = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(185, 9);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(185, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 81);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(185, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // buAdd
            // 
            this.buAdd.BackColor = System.Drawing.Color.White;
            this.buAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buAdd.FlatAppearance.BorderSize = 0;
            this.buAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buAdd.Font = new System.Drawing.Font("Gilroy ExtraBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buAdd.Location = new System.Drawing.Point(0, 290);
            this.buAdd.Name = "buAdd";
            this.buAdd.Size = new System.Drawing.Size(382, 63);
            this.buAdd.TabIndex = 9;
            this.buAdd.Text = "Добавить";
            this.buAdd.UseVisualStyleBackColor = false;
            this.buAdd.Click += new System.EventHandler(this.buAdd_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.AutoSize = true;
            this.cbGroup.Font = new System.Drawing.Font("Gilroy ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGroup.Location = new System.Drawing.Point(17, 209);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(206, 29);
            this.cbGroup.TabIndex = 10;
            this.cbGroup.Text = "Групповая задача";
            this.cbGroup.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 28);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // fmNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.buAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buAdd;
        private System.Windows.Forms.CheckBox cbGroup;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}