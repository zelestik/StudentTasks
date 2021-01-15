using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTasks
{
    public partial class fmLogin : Form
    {
        List<DateTime> unSuccessLogins = new List<DateTime>();
        int incorrectCapcha = 0;
        int capchaUpdates = 0;
        string text;
        public fmLogin()
        {
            InitializeComponent();
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!cbIsOffline.Checked) // Если не выбран оффлайн режим
            {
                if (txtUser.Text != "" && txtPass.Text != "" && incorrectCapcha < 7 && capchaUpdates < 15) // Проверка на пустые поля
                {
                        
                    // Создание объекта класса OnlineUser, username приводится к нижнему регистру
                    var user = new OnlineUser(txtUser.Text.ToLower(new CultureInfo("en-US", false)), txtPass.Text);
                    var loginRes = user.LoginUser();

                    if (loginRes == 1) //Успешный вход
                    {
                        // Открытие формы вывода задач
                        Form fmTasks = new fmTasks(user);
                        this.Hide();
                        fmTasks.Show();
                    }
                    // Сообщения об ошибках
                    else if (loginRes == -1)
                    {
                        unSuccessLogins.Add(DateTime.Now);
                        int count = 0;
                        foreach(var dt in unSuccessLogins)
                        {
                            if ((DateTime.Now - dt).TotalHours < 1)
                                count++;
                        }
                        if (count >= 5)
                            MakeCapcha();
                        MessageBox.Show("Неверный логин или пароль",
                            "Проверьте заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (loginRes == -2)
                        MessageBox.Show("Возникла ошибка сервера, проверьте подключение к интернету и доступность сервера",
                            "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (loginRes == -3)
                        MessageBox.Show("Пользователь заблокирован",
                            "Для работы в системе следуйте инструкциям из письма", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Имя пользователя или пароль не могут быть пустыми",
                        "Проверьте заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Если выбран оффлайн режим
            {
                try
                {
                    string username = File.ReadAllText(@"User");
                    
                    var res = MessageBox.Show
                        ("Найдены задачи пользователя " + username + "\nПродолжить?", "Подтвердите действие", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        var user = new OfflineUser(username);
                        Form fmTasks = new fmTasks(user);
                        this.Hide();
                        fmTasks.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("Авторизуйтесь онлайн для создания файла сохранения",
                        "Файл сохранения не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void cbOffline_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = !txtUser.Enabled;
            txtPass.Enabled = !txtPass.Enabled;
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(10);
            int Ypos = rnd.Next(10);

            //Добавим различные цвета ддя текста
            Brush[] colors = 
            {
                Brushes.Black,
                Brushes.DarkRed,
                Brushes.DarkBlue,
                Brushes.DarkGreen,
                Brushes.DarkOrange
            };

            //Добавим различные цвета линий
            Pen[] colorpens = {
                Pens.White,
                Pens.Tomato,
                Pens.Sienna,
                Pens.Pink,
                Pens.AliceBlue};

            Color[] BgColor =
            {
                Color.Aqua,
                Color.Aquamarine,
                Color.Azure,
                Color.Blue,
                Color.Bisque,
                Color.BlueViolet,
                Color.LightBlue,
                Color.LightGreen,
                Color.LightPink,
                Color.LightGray,
                Color.LightSalmon,
                Color.LightSeaGreen,
                Color.LightSkyBlue,
                Color.LightSlateGray,
                Color.LightYellow
            };

            //Делаем случайный стиль текста
            FontStyle[] fontstyle = 
            {
                FontStyle.Bold,
                FontStyle.Italic,
                FontStyle.Regular,
                FontStyle.Strikeout,
                FontStyle.Underline
            };

            //Добавим различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(BgColor[rnd.Next(BgColor.Length)]);

            //Делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));

            //Генерируем текст
            text = "";
            text += rnd.Next(9);
            string ALF = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < rnd.Next(5, 10); ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
            new Font("Arial", 8, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            //Линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, rnd.Next(Height-1)),
            new Point(Width - 1, rnd.Next(Height - 1)));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, rnd.Next(Height - 1)),
            new Point(Width - 1, rnd.Next(Height - 1)));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, rnd.Next(Height - 1)),
            new Point(Width - 1, rnd.Next(Height - 1)));

            //Белый шум
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void MakeCapcha()
        {
            if (txtUser.Text != "" && txtPass.Text != "" && !cbIsOffline.Checked)
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                cbIsOffline.Enabled = false;
                pictureBox1.Visible = true;
                txtCapcha.Visible = true;
                buNewCapcha.Visible = true;
                btnCheckCAPCHA.Visible = true;
                btnLogin.Enabled = false;
            }
            else
                MessageBox.Show("Имя пользователя или пароль не могут быть пустыми",
                        "Проверьте заполнение полей", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buNewCapcha_Click(object sender, EventArgs e)
        {
            if (capchaUpdates >= 15)
            {
                var con = new Connection();
                con.GetJSON("block/" + txtUser.Text);
                MessageBox.Show("На Ваш email отправлено письмо для смены пароля", "Учётная запись заблокирована", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
                capchaUpdates++;
            }
        }

        private void btnCheckCAPCHA_Click(object sender, EventArgs e)
        {
            if (txtCapcha.Text == text)
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                cbIsOffline.Enabled = true;
                pictureBox1.Visible = false;
                txtCapcha.Visible = false;
                buNewCapcha.Visible = false;
                btnLogin.Enabled = true;
            }
            else
            {
                MessageBox.Show("Капча введена неверно", "Капча введена неверно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                incorrectCapcha++;
                if (incorrectCapcha >= 7 || capchaUpdates >= 15)
                {
                    var con = new Connection();
                    con.GetJSON("block/" + txtUser.Text);
                    MessageBox.Show("На Ваш email отправлено письмо для смены пароля", "Учётная запись заблокирована", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }
    }
}
