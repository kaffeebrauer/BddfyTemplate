using System;
using BddfyVsix;
using BddfyVsix.Model;
using BddfyVsix.Presenter;
using NUnit.Framework;

namespace BddfyForm.Test
{
    [TestFixture]
    public class HelperFormTest
    {
        private HelperFormPresenter _presenter;
        private HelperForm _view;

        [SetUp]
        public void SetUp()
        {
            _view = new HelperForm();
            var model = new HelperFormModel();
            _presenter = new HelperFormPresenter(_view, model);
        }

        [Test]
        public void WithInvalidFieldsTheFormShouldNotBeClosed()
        {
            //Act
            _presenter.ViewOnSubmitButtonClick(new object(), EventArgs.Empty);

            //Assert
            Assert.IsTrue((_view).IsDisposed == false);
        }

        [Test]
        public void WithAllFieldsFilledFormShouldSubmitAndBeDisposed()
        {
            //Arrange
            _view.StoryAsATextBox.Text = @"ABC";
            _view.StoryIWantTextBox.Text = @"ABC";
            _view.StorySoThatTextBox.Text = @"ABC";


            _view.MainScenarioMethodTextBox.Text = @"ABC";
            _view.ScenarioTitleTextBox.Text = @"ABC";

            _view.MainActionItemTextBox.Text = @"ABC";
            _view.MainArrangementTextBox.Items.Add("ABC");
            _view.MainAssertionTextBox.Items.Add("ABC");

            //Act
            _presenter.ViewOnSubmitButtonClick(new object(), EventArgs.Empty);

            //Assert
            Assert.IsTrue((_view).IsDisposed);
        }
    }
}