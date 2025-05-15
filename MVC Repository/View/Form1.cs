using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MVC_Repository.Controller;
using MVC_Repository.Model;
using MVC_Repository.Repository;
using MySqlX.XDevAPI.Common;

namespace MVC_Repository
{
    public partial class Form1 : Form
    {

        private readonly UserRepository _userRepository;
        private readonly UserController _userController;
        private int selectedUserId = -1;
        public Form1()
        {
            _userRepository = new UserRepository();
            _userController = new UserController(_userRepository);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string destPath = string.Empty;

                if (pictureBox1.Image != null)
                {
                    string sourcePath = pictureBox1.Tag.ToString();
                    destPath=SaveNewImage(sourcePath);
                 
                }

                var user = new User
                {
                    Name = textBox1.Text.Trim(),
                    City = textBox2.Text.Trim(),
                    Image = destPath
                };
                string result =await _userController.CreateUser(user);
                MessageBox.Show(result);
                LoadUsers();
                clearField();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Tag = openFileDialog1.FileName; // Store path temporarily
            }
        }

        private async void LoadUsers()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;

            var users = await _userController.GetUsers();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Image", typeof(Image));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("path", typeof(string));

            foreach (var user in users)
            {
                Image img;
                if (File.Exists(user.Image))
                {
                    using (var fs = new FileStream(user.Image, FileMode.Open, FileAccess.Read))
                    {
                        using (var ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            img = Image.FromStream(new MemoryStream(ms.ToArray()));
                        }
                    }
                }
                else
                {

                    string defaultImagePath = Path.Combine(Application.StartupPath, "Images", "default.png");
                     img = Image.FromFile(defaultImagePath);
                }

                table.Rows.Add(user.Id, img, user.Name, user.City, user.Image);
            }

            dataGridView1.DataSource = table;

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["path"].Visible = false;

            if (dataGridView1.Columns["Image"] is DataGridViewImageColumn imageColumn)
            {
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Width = 80;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.Padding = new Padding(5);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }


        private async void button4_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string path = dataGridView1.CurrentRow.Cells["path"].Value.ToString();
                // Delete the image file if it exists
                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete image: " + ex.Message);
                    }
                }
                string result = await _userController.DeleteUser(selectedUserId);
                MessageBox.Show(result);

                LoadUsers();
                selectedUserId = -1;
                clearField();
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["Id"].Value); // Store ID internally
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["City"].Value.ToString();
                pictureBox1.Image = (Image)row.Cells["Image"].Value;
            }
        }
        private void clearField()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.Image = null;
        }

       
        

        private async void button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }
            int id = selectedUserId;
            string oldPath = dataGridView1.CurrentRow.Cells["path"].Value.ToString();
            string sourcePath;

            if (pictureBox1.Tag == null)
            {
                sourcePath = oldPath;
            }
            else
            {
                sourcePath = pictureBox1.Tag.ToString();
            }
            String destPath = UpdateImage(oldPath, sourcePath);

            var user = new User
            {
                Id = id,
                Name = textBox1.Text.Trim(),
                City = textBox2.Text.Trim(),
                Image = destPath
            };
            string result = await _userController.UpdateUser(user);
            MessageBox.Show(result);
            selectedUserId = -1;

            LoadUsers();
            clearField();
        }



        private string SaveNewImage(string sourcePath)
        {
            string fileName = Path.GetFileName(sourcePath);
            string imagesPath = Path.Combine(Application.StartupPath, "Images");
            Directory.CreateDirectory(imagesPath);

            string destPath = Path.Combine(imagesPath, DateTime.Now.ToString("yyyyMMdd_HHmmss") + "_" + fileName);
            File.Copy(sourcePath, destPath, true);

            return destPath;
        }



        private string UpdateImage(string oldPath, string newSourcePath)
        {
            string newImagePath = SaveNewImage(newSourcePath);

            if (File.Exists(oldPath) && oldPath != newImagePath)
            {
                File.Delete(oldPath);
            }

            return newImagePath;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
