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
            label1.Text = item.Text + "\n" + item.SubItems[1].Text + "\n" + item.SubItems[2].Text + "\nСделать до: " + item.SubItems[3].Text;
        }
    }
}
