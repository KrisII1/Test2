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
    public partial class InterestControls : System.Windows.Forms.UserControl
    {
       
        private DbManager<Interest, int> dbManager = new DbManager<Interest, int>(ContextGenerator.GetInterestContext());
        private Interest selectedInterest;
        public InterestControls()
        {
            InitializeComponent();
            LoadInteres();
        }
      
 

        private void FillTextBoxes(Interest selectedInterest)
        {
            if (selectedInterest != null)
            {
                textBox1.Text = selectedInterest.Name;
                textBox2.Text = selectedInterest.Area.ToString();
            }
        }
        private void LoadInteres()
        {
            interesDataGridView.DataSource = dbManager.ReadAll();
        }
        private void ClearTextBoxes()
        {
            textBox1.Text = string.Empty;
        }
        private Interest GetSelectedInterest()
        {
            return selectedInterest;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (selectedInterest != null)
                {
                    dbManager.Delete(selectedInterest.Id);
                    MessageBox.Show("Interest deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    selectedInterest = null;
                    LoadInteres();
                }
                else
                {
                    MessageBox.Show("Choose Interest from the table! ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void create_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                Area area = new Area(textBox2.Text);
                Interest interests = new Interest(name, area);
                
                dbManager.Create(interests);
                MessageBox.Show("Interes created successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInteres();

                ClearTextBoxes();

                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                selectedInterest.Name = textBox1.Text;


                dbManager.Update(selectedInterest);

                MessageBox.Show("Interest updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInteres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "@", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            selectedInterest = null;
            ClearTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void interesDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("🔥");
                return;
            }
            selectedInterest = interesDataGridView.Rows[e.RowIndex].DataBoundItem as Interest;
            FillTextBoxes(GetSelectedInterest());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
