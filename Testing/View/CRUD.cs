using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing.Controller;
using Testing.Model;
using Testing.Repository;

namespace Testing.View
{
    public partial class CRUD : Form
    {
        private UserRepository _userRepository;
        private UserController _userController;
        private int SelectedIndex = -1;
        public CRUD()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _userController = new UserController(_userRepository);

        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            var users =  _userController.GetUsers();
            dataGridView1.DataSource = users;
        }
        private  void clear()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = textBox1.Text.Trim(),
                City = textBox2.Text.Trim(),
            };
            string result =await _userController.CreateUser(user);
            MessageBox.Show(result);
            load();
                          
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if(SelectedIndex == -1)
            {
                MessageBox.Show("Need for update selected user");
                return;
            }
            var user = new User 
            { 
                Id = SelectedIndex,
                Name = textBox1.Text.Trim(),
                City = textBox2.Text.Trim(),
            };
           string result = await _userController.UpdateUser(user);

            MessageBox.Show(result);
            load();
            clear();

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                MessageBox.Show("Need for delete selected user");
                return;
            }
            var user = new User
            {
                Id = SelectedIndex,
            };
            string result =await _userController.DeleteUser(user);
            MessageBox.Show(result);
            load();
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SelectedIndex = Convert.ToInt32(row.Cells["Id"].Value); // Store ID internally
                textBox1.Text = Convert.ToString(row.Cells["Name"].Value);
                textBox2.Text = Convert.ToString(row.Cells["Name"].Value);
            }
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CRUD_Load_1(object sender, EventArgs e)
        {

        }
    }
}
