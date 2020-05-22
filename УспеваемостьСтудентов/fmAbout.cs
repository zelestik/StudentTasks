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
            tbName.Text = user.Name;
            if (user.Group == null || user.Group == "")
                laGroup.Text = "Вы не прикреплены к группе ";
            else
                laGroup.Text += user.Group;
            if (user.Role == 0)
                laRole.Text += "Студент";
            else if (user.Role == 1)
                laRole.Text += "Староста";
            else if (user.Role == 2)
                laRole.Text += "Администратор";
        }

    }
}
