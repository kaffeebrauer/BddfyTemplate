using System;
using System.Drawing;
using System.Windows.Forms;

namespace BddfyVsix
{
    public partial class HelperForm : Form
    {
        public HelperForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isValid = true;
            //Check if all mandatory fields have values, if not set border as red.
            if (string.IsNullOrWhiteSpace(StoryAsATextBox.Text))
            {
                StoryAsATextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                StoryAsATextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(StoryIWantTextBox.Text))
            {
                StoryIWantTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                StoryIWantTextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(StorySoThatTextBox.Text))
            {
                StorySoThatTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                StorySoThatTextBox.BackColor = Color.White;
            }
            
            if (string.IsNullOrWhiteSpace(MainScenarioMethodTextBox.Text))
            {
                MainScenarioMethodTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                MainScenarioMethodTextBox.BackColor = Color.White;
            }
            

            if (string.IsNullOrWhiteSpace(ScenarioTitleTextBox.Text))
            {
                ScenarioTitleTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                ScenarioTitleTextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(MainActionItemTextBox.Text))
            {
                MainActionItemTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                MainActionItemTextBox.BackColor = Color.White;
            }


            if (IsUseBaseTest.Checked && string.IsNullOrWhiteSpace(BaseTestClassNameTextBox.Text))
            {
                BaseTestClassNameTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                BaseTestClassNameTextBox.BackColor = Color.White;
            }

            if (IsUseBaseTest.Checked && string.IsNullOrWhiteSpace(ImplementedClassTextBox.Text))
            {
                ImplementedClassTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                ImplementedClassTextBox.BackColor = Color.White;
            }

            if (MainArrangementTextBox.Items.Count == 0)
            {
                MainArrangementTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                MainArrangementTextBox.BackColor = Color.White;
            }

            if (MainAssertionTextBox.Items.Count == 0)
            {
                MainAssertionTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                MainAssertionTextBox.BackColor = Color.White; 

            }

            if(isValid)
            {
                Close();
            }
        }

        private void AddMainArragementButton_Click(object sender, EventArgs e)
        {
            MainArrangementTextBox.Items.Add(MainArrangementItemTextBox.Text);
            MainArrangementItemTextBox.Clear();
        }

        private void AddMainAssertionButton_Click(object sender, EventArgs e)
        {
            MainAssertionTextBox.Items.Add(MainAssertionItemTextBox.Text);
            MainAssertionItemTextBox.Clear();
        }

        private void RemoveMainArragementButton_Click(object sender, EventArgs e)
        {
            if (MainArrangementTextBox.SelectedIndex != -1)
            {
                var item = MainArrangementTextBox.Items[MainArrangementTextBox.SelectedIndex];
                MainArrangementTextBox.Items.Remove(item);
            }

        }

        private void RemoveMainAssertionButton_Click(object sender, EventArgs e)
        {
            if (MainAssertionTextBox.SelectedIndex != -1)
            {
                var item = MainAssertionTextBox.Items[MainAssertionTextBox.SelectedIndex];
                MainAssertionTextBox.Items.Remove(item);
            }
        }
    }
}