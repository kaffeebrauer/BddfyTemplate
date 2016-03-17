using System;
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
            Close();
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