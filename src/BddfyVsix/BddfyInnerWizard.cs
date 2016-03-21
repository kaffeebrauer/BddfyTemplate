using System.Collections.Generic;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace BddfyVsix
{
    public class BddfyInnerWizard : IWizard
    {
        private DTE _dte;

        /// <summary>
        ///     Runs custom wizard logic at the beginning of a template wizard run.
        /// </summary>
        /// <param name="automationObject">The automation object being used by the template wizard.</param>
        /// <param name="replacementsDictionary">The list of standard parameters to be replaced.</param>
        /// <param name="runKind">
        ///     A <see cref="T:Microsoft.VisualStudio.TemplateWizard.WizardRunKind" /> indicating the type of
        ///     wizard run.
        /// </param>
        /// <param name="customParams">The custom parameters with which to perform parameter replacement in the project.</param>
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary,
            WizardRunKind runKind, object[] customParams)
        {
            _dte = (DTE) automationObject;
            runKind = WizardRunKind.AsNewItem;

            var form = new HelperForm();
            form.ShowDialog();

            replacementsDictionary.Add("$StoryAs$", form.StoryAsATextBox.Text);
            replacementsDictionary.Add("$StoryIWant$", form.StoryIWantTextBox.Text);
            replacementsDictionary.Add("$StorySoThat$", form.StorySoThatTextBox.Text);

            #region Arrangement Section
            if (form.MainArrangementTextBox.Items.Count == 1)
            { 
                replacementsDictionary.Add("$MainArrangementSection$", string.Format("public void {0}() {{ \n }}", form.MainArrangementTextBox.Items[0]));
                replacementsDictionary.Add("$MainArrangementStatements$", string.Format("this.Given(_ => {0}())", form.MainArrangementTextBox.Items[0]));
            } 
            else
            {
                var index = 0;
                var mainArrangementSectionReplacementString = string.Empty;
                var mainArrangementStatementsReplacementString = string.Empty;
                foreach(var i in form.MainArrangementTextBox.Items)
                {
                    mainArrangementSectionReplacementString += string.Format("public void {0}() {{ \n }} \n\n", i);
                    if (index == 0)
                    {
                        mainArrangementStatementsReplacementString += string.Format("this.Given(_ => {0}())\n", i);
                    }
                    else if (index == form.MainArrangementTextBox.Items.Count -1)
                    {
                        mainArrangementStatementsReplacementString += string.Format("\t\t\t\t.And(_ => {0}())", i);
                    }
                    else
                    {
                        mainArrangementStatementsReplacementString += string.Format("\t\t\t\t.And(_ => {0}())\n", i);
                    }

                    index++;
                }
                replacementsDictionary.Add("$MainArrangementSection$", mainArrangementSectionReplacementString);
                replacementsDictionary.Add("$MainArrangementStatements$", mainArrangementStatementsReplacementString);

            }
            #endregion

            replacementsDictionary.Add("$MainActSection$", string.Format("public void {0}() {{ \n }}", form.MainActionItemTextBox.Text));

            #region Assertion Section
            if (form.MainAssertionTextBox.Items.Count == 1)
            {
                replacementsDictionary.Add("$MainAssertionSection$", string.Format("public void {0}() {{ \n }}", form.MainAssertionTextBox.Items[0]));
                replacementsDictionary.Add("$MainAssertionStatements$", string.Format(".Then(_ => {0}())", form.MainAssertionTextBox.Items[0]));
            }
            else
            {
                var index = 0;
                var mainAssertionSectionReplacementString = string.Empty;
                var mainAssertionStatementsReplacementString = string.Empty;
                foreach (var i in form.MainAssertionTextBox.Items)
                {
                    mainAssertionSectionReplacementString += string.Format("public void {0}() {{ \n }} \n\n", i);
                    if (index == 0)
                    {
                        mainAssertionStatementsReplacementString += string.Format(".Then(_ => {0}())\n", i);
                    }
                    else if (index == form.MainAssertionTextBox.Items.Count -1)
                    {
                        mainAssertionStatementsReplacementString += string.Format("\t\t\t\t.And(_ => {0}())", i);
                    }
                    else
                    {
                        mainAssertionStatementsReplacementString += string.Format("\t\t\t\t.And(_ => {0}())\n", i);
                    }
                    index++;
                }
                replacementsDictionary.Add("$MainAssertionSection$", mainAssertionSectionReplacementString);
                replacementsDictionary.Add("$MainAssertionStatements$", mainAssertionStatementsReplacementString);
            }
            #endregion

            replacementsDictionary.Add("$MainScenarioMethod$", form.MainScenarioMethodTextBox.Text);
            //TODO: perhap use Humanizr to format this?

            replacementsDictionary.Add("$MainAct$", form.MainActionItemTextBox.Text);
            replacementsDictionary.Add("$ScenarioTitle$", form.ScenarioTitleTextBox.Text);

            var baseClassChecked = form.IsUseBaseTest.Checked;
            if (baseClassChecked)
            {
                var interfacingClass = string.Format(": {0}<{1}>", form.BaseTestClassNameTextBox.Text, form.ImplementedClassTextBox.Text);
                replacementsDictionary.Add("$ImplementedClass$", interfacingClass);
            } 
            else
            {
                replacementsDictionary.Add("$ImplementedClass$", string.Empty);
            }
        }

        /// <summary>
        ///     Runs custom wizard logic when a project has finished generating.
        /// </summary>
        /// <param name="project">The project that finished generating.</param>
        public void ProjectFinishedGenerating(Project project)
        {
        }

        /// <summary>
        ///     Runs custom wizard logic when a project item has finished generating.
        /// </summary>
        /// <param name="projectItem">The project item that finished generating.</param>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        /// <summary>
        ///     Indicates whether the specified project item should be added to the project.
        /// </summary>
        /// <returns>
        ///     true if the project item should be added to the project; otherwise, false.
        /// </returns>
        /// <param name="filePath">The path to the project item.</param>
        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        /// <summary>
        ///     Runs custom wizard logic before opening an item in the template.
        /// </summary>
        /// <param name="projectItem">The project item that will be opened.</param>
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        /// <summary>
        ///     Runs custom wizard logic when the wizard has completed all tasks.
        /// </summary>
        public void RunFinished()
        {
        }
    }
}