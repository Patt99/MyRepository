using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sesion2
{
    public partial class client : Form
    {
        string conStr = @"data source=vc-stud-mssql1;user id=user79_db;password=user79;MultipleActiveResultSets=True;App=EntityFramework";
        SqlConnection connection;
        string photo = "";
        public client(string title)
        {
            InitializeComponent();
            connection = new SqlConnection(conStr);
            string active = "";
            connection.Open();
            string q = "SELECT * FROM Product where Title =" + "'"+title + "'";
            MessageBox.Show(q);
            string pic = "D:\\Sai\\фото\\";
            SqlCommand cmd = new SqlCommand(q);
            cmd.Connection = connection;


            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                textBox1.Text = rd.GetValue(0).ToString();
                textBox2.Text = rd.GetValue(1).ToString();
                textBox3.Text = rd.GetValue(2).ToString();
                textBox4.Text = rd.GetValue(3).ToString();
                textBox5.Text = rd.GetValue(6).ToString();
                pic += rd.GetValue(4).ToString().Substring(29);
                active = rd.GetValue(5).ToString();

            }
            rd.Close();
            image3.BackgroundImage = Image.FromFile(pic);
            if (active == "1")
            {
                radioButton1.Checked = true;
            }
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string paz = "";
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    this.image3.Size = image.Size;
                    image3.Image = image;
                    image3.Invalidate();
                    paz += image3.BackgroundImage;
                    photo = open_dialog.FileName;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string Id = textBox1.Text;
            string cost = textBox3.Text;
            string title = textBox2.Text;
            string de = textBox4.Text;
            string pro = textBox5.Text;
            string active = "";
            if (radioButton1.Checked==true) {
               active = "1";
            }
            else {
                active = "0";
            }
            
            if (photo != "")
            {
                photo = photo.Substring(61);
                string stdimgpath= "'D:\\Sai\\Фото\\";
                stdimgpath += photo+"'";
                string item = String.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6} ", Id, title, cost, de, stdimgpath, active, pro);

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = String.Format("update Product set Title = '{1}', Cost = '{2}',Description = '{3}',MainImagePath = {4},IsActive = '{5}',ManufacturerID = '{6}' where ID = '{0}" +
                    "'", Id, title, cost, de, stdimgpath,active,pro);
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("Товар " +title + " успешно обновлен!"), "Сообщение");
            }
            else
            {
                string item = String.Format("{0} | {1} | {2} | {3} | {4}   ", Id, title, cost, de,  active);

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = String.Format("update Product set Title = '{1}', Cost = '{2}',Description = '{3}',IsActive = '{4}',ManufacturerID = '{5}' where ID = '{0}" +
                    "'", Id, title, cost, de, active, pro);
                cmd.ExecuteNonQuery();
                MessageBox.Show(string.Format("Товар " + title + " успешно обновлен!"), "Сообщение");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
