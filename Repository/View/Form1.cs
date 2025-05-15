using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Contract;
using Repository.Controller;
using Repository.Model;

namespace Repository
{
    public partial class Form1 : Form
    {
        private UserRepository _userRepository;
        private UserController controller;
        private int selectedUserId = -1;
        public Form1()
        {
            InitializeComponent();
            _userRepository = new UserRepository(); // Initialize UserRepository
            controller = new UserController(_userRepository); // 
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = new UserModel
            {
                Name = textBox1.Text.Trim(),
                City = textBox2.Text.Trim()
            };

            string result = await controller.AddUserAsync(user);
            MessageBox.Show(result);
            LoadUsers();
            fieldClear();
        }

        private async void LoadUsers()
        {
            var users = await controller.GetAllUsersAsync();
            dataGridView1.DataSource = users;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            var user = new UserModel
            {
                Id = selectedUserId,
                Name = textBox1.Text.Trim(),
                City = textBox2.Text.Trim()
            };

            string result = await controller.UpdateUserAsync(user);
            MessageBox.Show(result);
            textBox1.Clear();
            textBox2.Clear();
            LoadUsers();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string result = await controller.DeleteUserAsync(selectedUserId);
                MessageBox.Show(result);
                LoadUsers();
                selectedUserId = -1;
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedUserId = Convert.ToInt32(row.Cells["Id"].Value); // Store ID internally
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["City"].Value.ToString();
            }
        }

        private  void  Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private  void fieldClear()
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
