using System;
using System.Windows.Forms;
using BddfyVsix;
using BddfyVsix.Model;
using BddfyVsix.Presenter;
using BddfyVsix.View;
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

            _presenter.ViewOnSubmitButtonClick(new object(), EventArgs.Empty);
            Assert.IsTrue(((Form)_view).IsDisposed == false);
        }

    }
}
