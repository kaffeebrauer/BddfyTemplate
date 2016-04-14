using System;
using System.Drawing;
using System.Windows.Forms;
using BddfyForm;
using BddfyForm.Model;
using BddfyForm.Presenter;
using BddfyVsix.View;

namespace BddfyVsix.Presenter
{
    public class HelperFormPresenter : IPresenter
    {
        private readonly IModel _model;
        private readonly IHelperFormView _view;

        public HelperFormPresenter(IHelperFormView view, IModel model)
        {
            //Register the Winform events
            view.SubmitButtonClick += ViewOnSubmitButtonClick;
            view.AddMainArragementButtonClick += ViewOnAddMainArragementButtonClick;
            view.AddMainAssertionButtonClick += ViewOnAddMainAssertionButtonClick;
            view.RemoveMainArragementButtonClick += ViewOnRemoveMainArragementButtonClick;
            view.RemoveMainAssertionButtonClick += ViewOnRemoveMainAssertionButtonClick;

            _view = view;
            _model = model;

        }

        private void ViewOnRemoveMainArragementButtonClick(object sender, EventArgs eventArgs)
        {
            var view = (HelperForm) _view;
            if (view.MainArrangementTextBox.SelectedIndex != -1)
            {
                var item = view.MainArrangementTextBox.Items[view.MainArrangementTextBox.SelectedIndex];
                view.MainArrangementTextBox.Items.Remove(item);
            }
        }

        private void ViewOnAddMainAssertionButtonClick(object sender, EventArgs eventArgs)
        {
            var view = (HelperForm) _view;
            if (!string.IsNullOrWhiteSpace(view.MainAssertionItemTextBox.Text))
            {
                view.MainAssertionTextBox.Items.Add(view.MainAssertionItemTextBox.Text);
                view.MainAssertionItemTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please provide an input");
            }
        }

        private void ViewOnAddMainArragementButtonClick(object sender, EventArgs eventArgs)
        {
            var view = (HelperForm) _view;
            if (!string.IsNullOrWhiteSpace(view.MainArrangementItemTextBox.Text))
            { 
                view.MainArrangementTextBox.Items.Add(view.MainArrangementItemTextBox.Text);
                view.MainArrangementItemTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please provide an input");
            }
        }


        public void ViewOnSubmitButtonClick(object sender, EventArgs eventArgs)
        {
            var view = (HelperForm) _view;
            var isValid = true;
            //Check if all mandatory fields have values, if not set border as red.
            if (string.IsNullOrWhiteSpace(view.StoryAsATextBox.Text))
            {
                view.StoryAsATextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.StoryAsATextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(view.StoryIWantTextBox.Text))
            {
                view.StoryIWantTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.StoryIWantTextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(view.StorySoThatTextBox.Text))
            {
                view.StorySoThatTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.StorySoThatTextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(view.MainScenarioMethodTextBox.Text))
            {
                view.MainScenarioMethodTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.MainScenarioMethodTextBox.BackColor = Color.White;
            }


            if (string.IsNullOrWhiteSpace(view.ScenarioTitleTextBox.Text))
            {
                view.ScenarioTitleTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.ScenarioTitleTextBox.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(view.MainActionItemTextBox.Text))
            {
                view.MainActionItemTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.MainActionItemTextBox.BackColor = Color.White;
            }


            if (view.IsUseBaseTest.Checked && string.IsNullOrWhiteSpace(view.BaseTestClassNameTextBox.Text))
            {
                view.BaseTestClassNameTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.BaseTestClassNameTextBox.BackColor = Color.White;
            }

            if (view.IsUseBaseTest.Checked && string.IsNullOrWhiteSpace(view.ImplementedClassTextBox.Text))
            {
                view.ImplementedClassTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.ImplementedClassTextBox.BackColor = Color.White;
            }

            if (view.MainArrangementTextBox.Items.Count == 0)
            {
                view.MainArrangementTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.MainArrangementTextBox.BackColor = Color.White;
            }

            if (view.MainAssertionTextBox.Items.Count == 0)
            {
                view.MainAssertionTextBox.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                view.MainAssertionTextBox.BackColor = Color.White;
            }

            if (isValid)
            {
                view.Close();
            }
        }

        private void ViewOnRemoveMainAssertionButtonClick(object sender, EventArgs eventArgs)
        {
            var view = (HelperForm) _view;
            if (view.MainAssertionTextBox.SelectedIndex != -1)
            {
                var item = view.MainAssertionTextBox.Items[view.MainAssertionTextBox.SelectedIndex];
                view.MainAssertionTextBox.Items.Remove(item);
            }
        }
    }
}