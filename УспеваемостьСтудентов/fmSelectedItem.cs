using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УспеваемостьСтудентов
{
    public partial class fmSelectedItem : Form
    {
        public fmSelectedItem(ListViewItem item)
        {
            InitializeComponent();
            try
            {
                var task = (Task)item.Tag;
                
                laName.Text = task.Name + ". " + task.Type;
                tbDescription.Text = item.SubItems[1].Text;
                //dateTimePicker1.Value = (date)item.SubItems[3].Text;
            }
            catch
            {

            }
        }

    }
}
