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
    public partial class fmAbout : Form
    {
        public fmAbout(OnlineUser user)
        {
            InitializeComponent();
            txtName.Text = user.Name;
            if (user.Group == null || user.Group == "")
                lblGroup.Text = "Вы не прикреплены к группе ";
            else
                lblGroup.Text += user.Group;
            if (user.Role == 0)
                lblRole.Text += "Студент";
            else if (user.Role == 1)
                lblRole.Text += "Староста";
            else if (user.Role == 2)
                lblRole.Text += "Администратор";
        }

        private void btnLoginHistory_Click(object sender, EventArgs e)
        {
            var fm = new fmLoginHistory();
            fm.Show();
        }
    }
}
