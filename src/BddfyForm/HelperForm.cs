using System;
using System.Windows.Forms;
using BddfyForm.Model;
using BddfyVsix.Presenter;
using BddfyVsix.View;

namespace BddfyForm
{
    public partial class HelperForm : Form, IHelperFormView
    {
        //private HelperFormPresenter _presenter;

        public HelperForm()
        {
            InitializeComponent();
           
            var model = new HelperFormModel();
            // ReSharper disable once ObjectCreationAsStatement
            new HelperFormPresenter(this, model);

            //Register the event handlers
            RemoveMainArragementButton.Click += RemoveMainArragementButtonClick;
            RemoveMainAssertionButton.Click += RemoveMainAssertionButtonClick;
            AddMainAssertionButton.Click += AddMainAssertionButtonClick;
            AddMainArragementButton.Click += AddMainArragementButtonClick;
            SubmitButton.Click += SubmitButtonClick;
        }

        public event EventHandler SubmitButtonClick;
        public event EventHandler AddMainArragementButtonClick;
        public event EventHandler AddMainAssertionButtonClick; 
        public event EventHandler RemoveMainArragementButtonClick;
        public event EventHandler RemoveMainAssertionButtonClick;

        public void OnPropertyChanged(HelperFormModel model)
        {
            throw new NotImplementedException();
        }
    }
}