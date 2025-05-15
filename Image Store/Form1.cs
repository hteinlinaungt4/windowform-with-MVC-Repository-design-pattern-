using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
namespace Image_Store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string sourcePath = pictureBox1.Tag.ToString();
                string fileName = Path.GetFileName(sourcePath);
                string destFolder = @"C:\AppImages\";

                if (!Directory.Exists(destFolder))
                    Directory.CreateDirectory(destFolder);

                string destPath = Path.Combine(destFolder, fileName);
                File.Copy(sourcePath, destPath, true); // Overwrite if exists

                string connStr = "server=localhost;user=root;password=root;database=mvc;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "INSERT INTO Image (name, image) VALUES (@name, @path)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@path", destPath);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Image path saved successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a name and select an image.");
            }
        }
    }
}
