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
            this.laSubject.Location = new System.Drawing.Point(13, 10);
            this.laSubject.Name = "laSubject";
            this.laSubject.Size = new System.Drawing.Size(66, 17);
            this.laSubject.TabIndex = 0;
            this.laSubject.Text = "Предмет";
            // 
            // laDescription
            // 
            this.laDescription.AutoSize = true;
            this.laDescription.Location = new System.Drawing.Point(13, 46);
            this.laDescription.Name = "laDescription";
            this.laDescription.Size = new System.Drawing.Size(74, 17);
            this.laDescription.TabIndex = 1;
            this.laDescription.Text = "Описание";
            // 
            // laType
            // 
            this.laType.AutoSize = true;
            this.laType.Location = new System.Drawing.Point(13, 85);
            this.laType.Name = "laType";
            this.laType.Size = new System.Drawing.Size(84, 17);
            this.laType.TabIndex = 2;
            this.laType.Text = "Тип задачи";
            // 
            // laExpDate
            // 
            this.laExpDate.AutoSize = true;
            this.laExpDate.Location = new System.Drawing.Point(12, 121);
            this.laExpDate.Name = "laExpDate";
            this.laExpDate.Size = new System.Drawing.Size(101, 17);
            this.laExpDate.TabIndex = 3;
            this.laExpDate.Text = "Выполнить до";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // buAdd
            // 
            this.buAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buAdd.Location = new System.Drawing.Point(0, 240);
            this.buAdd.Name = "buAdd";
            this.buAdd.Size = new System.Drawing.Size(292, 23);
            this.buAdd.TabIndex = 9;
            this.buAdd.Text = "Добавить";
            this.buAdd.UseVisualStyleBackColor = true;
            this.buAdd.Click += new System.EventHandler(this.buAdd_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.AutoSize = true;
            this.cbGroup.Location = new System.Drawing.Point(129, 150);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(151, 21);
            this.cbGroup.TabIndex = 10;
            this.cbGroup.Text = "Групповая задача";
            this.cbGroup.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // fmNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 263);
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
            this.MaximumSize = new System.Drawing.Size(310, 310);
            this.MinimumSize = new System.Drawing.Size(310, 310);
            this.Name = "fmNewTask";
            this.Text = "fmNewTask";
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