using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Api_test.Controller;
using Api_test.Model;
using MaterialSkin;

namespace Api_test
{
    public partial class Form1 : Form
    {
        private readonly ApiController _apiController;
        public Form1()
        {
            _apiController = new ApiController();
            InitializeComponent();
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            var data = await _apiController.GetAllObjects();
            materialListBox1.Items.Clear();

            foreach (var item in data)
            {
                materialListBox1.Items.Add(new MaterialListBoxItem($"ID: {item.id}"));
                materialListBox1.Items.Add(new MaterialListBoxItem($"Name: {item.name}"));

                if (item.data != null)
                {
                    foreach (var kvp in item.data)
                    {
                        materialListBox1.Items.Add(new MaterialListBoxItem($"    {kvp.Key}: {kvp.Value}"));
                    }
                }
                else
                {
                    materialListBox1.Items.Add(new MaterialListBoxItem("    No additional data."));
                }

                materialListBox1.Items.Add(new MaterialListBoxItem("-----------------------------"));
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var newObj = new ApiModel
            {
                name = materialMaskedTextBox1.Text,
                data = new Dictionary<string, string>
                    {
                        { "color", materialMaskedTextBox2.Text },
                        { "capacity", materialMaskedTextBox3.Text }
                    }
            };
            var result = _apiController.CreateApi(newObj);
            MessageBox.Show($"Created with ID: {result.Id}");
        }
    }
}
