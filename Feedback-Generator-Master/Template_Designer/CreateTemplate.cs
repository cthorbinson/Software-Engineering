using System;
using System.Data;
using System.Windows.Forms;

namespace Template_Designer
{
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Confirm Button Click.
            
            CreateNewTemplate input = new CreateNewTemplate();
            input.addTemplateName(textBoxTemplateName.Text);
            input.addTemplateReviewer(textBoxTemplateReviewer.Text);
            input.addTemplatePosition(textBoxTemplatePosition.Text);
            input.addTemplateFeedbackType(comboBoxSelectFeedbackTypeBox.Text);
            input.writeTemplateDetailsToDB();
            enterSectionTitle sectionTitleEnter = new enterSectionTitle();
            sectionTitleEnter.Show();
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {
            //Unused code.
            // TODO: This line of code loads data into the 'feedbackGeneratorDBDataSet.createTemplateFeedbackType' table. You can move, or remove it, as needed.
            this.createTemplateFeedbackTypeTableAdapter.Fill(this.feedbackGeneratorDBDataSet.createTemplateFeedbackType);

        }

        private void templateName_TextChanged(object sender, EventArgs e)
        {
            //Template Name Box.
        }

        private void reviewerName_TextChanged(object sender, EventArgs e)
        {
            //template reviewer box
        }

        private void positionName_TextChanged(object sender, EventArgs e)
        {
            //template position box
        }

        private void selectFeedbackTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Template Feedback Input Box.
        }

    }
}
