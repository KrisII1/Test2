using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.UserControls
{
    public partial class UserControlz : System.Windows.Forms.UserControl
    {
       

        private DbManager<User, int> dbManager = new DbManager<User, int>(ServiceLayer.ContextGenerator.GetUserContext());
        private User selectedUser;
      
        public UserControlz()
        {
            InitializeComponent();
            LoadPotrebitel();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void name_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedUser.FirstName = name_txtBox.Text;
                selectedUser.LastName = textBox1.Text;
                selectedUser.Age = (int)age_numericUpDown.Value;
                selectedUser.Username = textBox2.Text;
                selectedUser.Password = textBox3.Text;
                selectedUser.Email = textBox4.Text;


                dbManager.Update(selectedUser);

                MessageBox.Show("User updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPotrebitel();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser != null)
                {
                    dbManager.Delete(selectedUser.ID);
                    MessageBox.Show("User removed successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedUser = null;
                    LoadPotrebitel();
                }
                else
                {
                    MessageBox.Show("Choose user from the table!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("!");
                return;
            }
            selectedUser = userDataGridView.Rows[e.RowIndex].DataBoundItem as User;
            FillTextBoxes(GetSelectedPotrebitel());
        }

     
        private void ClearTextBoxes()
        {
            name_txtBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            age_numericUpDown.Value = 0;
            textBox4.Text = string.Empty;
        }

        private User GetSelectedPotrebitel()
        {
            return selectedUser;
        }

        private void FillTextBoxes(User selectedUser)
        {
            if (selectedUser != null)
            {
                name_txtBox.Text = selectedUser.FirstName;
                textBox1.Text = selectedUser.LastName;
                age_numericUpDown.Value = selectedUser.Age;
                textBox2.Text = selectedUser.Username;
                textBox3.Text = selectedUser.Password;
                textBox4.Text = selectedUser.Email;

            }
        }

        private void LoadPotrebitel()
        {
            userDataGridView.DataSource = dbManager.ReadAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void age_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = name_txtBox.Text;
                string LastName = textBox1.Text;
                decimal Age = age_numericUpDown.Value;
                string Username = textBox2.Text;
                string Password = textBox3.Text;
                string Email = textBox4.Text;
                User user = new User(FirstName, LastName, (int)Age, Username, Password, Email);
                dbManager.Create(user);
                MessageBox.Show("User created successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPotrebitel();

                ClearTextBoxes();

                name_txtBox.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_btn_Click_1(object sender, EventArgs e)
        {
            selectedUser = null;
            ClearTextBoxes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
