using Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Inventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblItemNo_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void tbxItemNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields here (e.g., non-empty, valid number for price)

                InventoryItem newItem = new InventoryItem()
                {
                    ItemNo = int.Parse(tbxItemNo.Text), // Ensure this text box contains a valid integer
                    Description = tbxDescription.Text,
                    Price = decimal.Parse(tbxPrice.Text) // Ensure this text box contains a valid decimal
                };

                var items = InventoryDB.GetItems();
                items.Add(newItem);
                InventoryDB.SaveItems(items);

                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close Form1 after adding the item
                this.Hide(); // 隐藏 Form1

                // Show Form2 and refresh its ListBox
                Form1 form2 = new Form1();
                form2.RefreshItemsList();
                form2.ShowDialog(); // 显示 Form2 作为对话框，这将阻止代码执行直到 Form2 关闭
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
