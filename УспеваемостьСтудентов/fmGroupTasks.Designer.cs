namespace УспеваемостьСтудентов
{
    partial class fmGroupTasks
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnToPersonal = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1150, 540);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // btnToPersonal
            // 
            this.btnToPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToPersonal.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnToPersonal.FlatAppearance.BorderSize = 0;
            this.btnToPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToPersonal.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToPersonal.ForeColor = System.Drawing.Color.White;
            this.btnToPersonal.Location = new System.Drawing.Point(808, 504);
            this.btnToPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToPersonal.Name = "btnToPersonal";
            this.btnToPersonal.Size = new System.Drawing.Size(168, 34);
            this.btnToPersonal.TabIndex = 9;
            this.btnToPersonal.Text = "В личные";
            this.btnToPersonal.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gilroy ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(982, 504);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отклонить";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // fmGroupTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1182, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnToPersonal);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Gilroy Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "fmGroupTasks";
            this.Opacity = 0.95D;
            this.Text = "Задачи группы: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnToPersonal;
        private System.Windows.Forms.Button btnCancel;
    }
}