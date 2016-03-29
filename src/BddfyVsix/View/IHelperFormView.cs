using System;
using BddfyVsix.Model;

namespace BddfyVsix.View
{
    public interface IHelperFormView
    {
        event EventHandler SubmitButtonClick;
        event EventHandler AddMainArragementButtonClick;
        event EventHandler AddMainAssertionButtonClick;
        event EventHandler RemoveMainArragementButtonClick;

        event EventHandler RemoveMainAssertionButtonClick; 
        void OnPropertyChanged(HelperFormModel model);
    }
}