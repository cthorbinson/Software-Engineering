using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_Designer
{
    public partial class editMenu : Form
    {
        public editMenu()
        {
            InitializeComponent();
        }

        TextBox TemplateNameTextbox = new TextBox();
        public static TextBox TemplateNameTextboxData = new TextBox();
        TextBox TemplateReviewerTextbox = new TextBox();
        public static TextBox TemplateReviewerTextboxData = new TextBox();
        TextBox TemplatePositionTextbox = new TextBox();
        public static TextBox TemplatePositionTextboxData = new TextBox();

        List<TextBox> sectionTitleTextbox = new List<TextBox>();
        public static List<TextBox> sectionTitleTextboxData = new List<TextBox>();

        public static List<TextBox> optionTitleTextbox = new List<TextBox>();
        public static List<TextBox> optionTitleTextboxData = new List<TextBox>();

        public static List<TextBox> optionCommentTextbox = new List<TextBox>();
        public static List<TextBox> optionCommentTextboxData = new List<TextBox>();

        static int sectionTitleNum = 126;
        static int sectionTitleDataNum = 126;
        static int optionTitleNum = 152;
        static int optionTitleDataNum = 152;
        static int optionCommentNum = 197;
        static int optionCommentNumData = 178;

        static int sectionTextBoxCount = 0;
        static int optionsTextBoxCount = 0;

        static int optionCount = 0;

        //public static int updateSectionTitleIndex = 0;

        //public static Control ctr;

        public void createTBEditTemplate()
        {
            TemplateNameTextbox.Location = new System.Drawing.Point(13, 12);
            TemplateNameTextbox.Name = "NameTB";
            TemplateNameTextbox.Size = new System.Drawing.Size(100, 20);
            TemplateNameTextbox.Text = "Template name";
            this.Controls.Add(TemplateNameTextbox);
            TemplateNameTextbox.BringToFront();

            TemplateNameTextboxData.Location = new System.Drawing.Point(133, 12);
            TemplateNameTextboxData.Name = "NameDB";
            TemplateNameTextboxData.Size = new System.Drawing.Size(173, 20);
            this.Controls.Add(TemplateNameTextboxData);
            TemplateNameTextboxData.BringToFront();

            TemplateReviewerTextbox.Location = new System.Drawing.Point(13, 38);
            TemplateReviewerTextbox.Name = "ReviewerTB";
            TemplateReviewerTextbox.Size = new System.Drawing.Size(100, 20);
            TemplateReviewerTextbox.Text = "Template Reviewer";
            this.Controls.Add(TemplateReviewerTextbox);
            TemplateReviewerTextbox.BringToFront();

            TemplateReviewerTextboxData.Location = new System.Drawing.Point(133, 38);
            TemplateReviewerTextboxData.Name = "ReviewerDB";
            TemplateReviewerTextboxData.Size = new System.Drawing.Size(173, 20);
            this.Controls.Add(TemplateReviewerTextboxData);
            TemplateReviewerTextboxData.BringToFront();

            TemplatePositionTextbox.Location = new System.Drawing.Point(13, 64);
            TemplatePositionTextbox.Name = "PositionTB";
            TemplatePositionTextbox.Size = new System.Drawing.Size(100, 20);
            TemplatePositionTextbox.Text = "Template Position";
            this.Controls.Add(TemplatePositionTextbox);
            TemplatePositionTextbox.BringToFront();

            TemplatePositionTextboxData.Location = new System.Drawing.Point(133, 64);
            TemplatePositionTextboxData.Name = "PositionDB";
            TemplatePositionTextboxData.Size = new System.Drawing.Size(173, 20);
            this.Controls.Add(TemplatePositionTextboxData);
            TemplatePositionTextboxData.BringToFront();

            for (int i = 0; i < editTemplate.sectID.Count; i++)
            {
                var sectionTextbox = new TextBox();
                var sectionTextboxData = new TextBox();

                sectionTextbox.Left = 74;
                sectionTextbox.Top = sectionTitleNum;
                sectionTextbox.Name = string.Format("SectionTitleTB {0}", sectionTextBoxCount);
                sectionTextbox.Size = new System.Drawing.Size(100, 20);
                sectionTextbox.Text = "Section title";
                this.Controls.Add(sectionTextbox);
                sectionTitleTextbox.Add(sectionTextbox);
                sectionTextbox.BringToFront();

                sectionTextboxData.Left = 202;
                sectionTextboxData.Top = sectionTitleDataNum;
                sectionTextboxData.Name = string.Format("SectionTitleData {0}", sectionTextBoxCount);
                sectionTextboxData.Size = new System.Drawing.Size(180, 20);
                this.Controls.Add(sectionTextboxData);
                sectionTitleTextboxData.Add(sectionTextboxData);
                sectionTextboxData.BringToFront();

                sectionTextBoxCount += 1;

                createEditOption();
            }

            foreach (TextBox optionsTitleElement in optionTitleTextbox)
            {
                this.Controls.Add(optionsTitleElement);
                optionsTitleElement.BringToFront();
            }

            foreach (TextBox optionsTitleDataElement in optionTitleTextboxData)
            {
                this.Controls.Add(optionsTitleDataElement);
                optionsTitleDataElement.BringToFront();
            }

            foreach (TextBox optionsCommentElement in optionCommentTextbox)
            {
                this.Controls.Add(optionsCommentElement);
                optionsCommentElement.BringToFront();
            }

            foreach (TextBox optionsCommentDataElement in optionCommentTextboxData)
            {
                this.Controls.Add(optionsCommentDataElement);
                optionsCommentDataElement.BringToFront();
            }

            optionCount = 0;

        }

        public void createEditOption()
        {
            DBConnection.getDBConnectionToInstance().makeTemplateOption(Constants.SQLCreateEditOption, editTemplate.sectID[optionCount]);
            optionCount += 1;
        }

        public void createFillEditOption()
        {
            TextBox optionTitleText = new TextBox();
            TextBox optionTitleTextData = new TextBox();

            optionTitleText.Left = 144;
            optionTitleText.Top = optionTitleNum;
            optionTitleText.Name = string.Format("OptionTitleTB {0}", optionsTextBoxCount);
            optionTitleText.Size = new System.Drawing.Size(100, 20);
            optionTitleText.Text = "Option title";
            optionTitleTextbox.Add(optionTitleText);

            optionTitleTextData.Left = 271;
            optionTitleTextData.Top = optionTitleDataNum;
            optionTitleTextData.Name = string.Format("OptionTitleData {0}", optionsTextBoxCount);
            optionTitleTextData.Size = new System.Drawing.Size(180, 20);
            optionTitleTextboxData.Add(optionTitleTextData);

            TextBox optionCommentText = new TextBox();
            TextBox optCommentData = new TextBox();

            optionCommentText.Left = 144;
            optionCommentText.Top = optionCommentNum;
            optionCommentText.Name = string.Format("OptionCommentTB {0}", optionsTextBoxCount);
            optionCommentText.Size = new System.Drawing.Size(100, 20);
            optionCommentText.Text = "Option comment";
            optionCommentTextbox.Add(optionCommentText);

            optCommentData.Left = 271;
            optCommentData.Top = optionCommentNumData;
            optCommentData.Multiline = true;
            optCommentData.Name = string.Format("OptionCommentDB {0}", optionsTextBoxCount);
            optCommentData.Size = new System.Drawing.Size(142, 59);
            optionCommentTextboxData.Add(optCommentData);

            sectionTitleNum += 130;
            sectionTitleDataNum += 130;
            optionTitleNum += 130;
            optionTitleDataNum += 130;
            optionCommentNumData += 130;
            optionCommentNum += 130;

            optionsTextBoxCount += 1;
        }

        public void fillEditTemplate()
        {
            DBConnection.getDBConnectionToInstance().fillTemplate(Constants.SQLFillEditTemplate, editTemplate.tempEditID);
        }

        public void fillEditSection()
        {
            DBConnection.getDBConnectionToInstance().fillSection(Constants.SQLFillEditSection, editTemplate.tempEditID);
        }

        public void fillEditOption()
        {
            foreach (int optionTitleEditElement in editTemplate.opID)
            {
                DBConnection.getDBConnectionToInstance().fillOptionTitle(Constants.SQLFillEditOptionTitle, optionTitleEditElement);
            }
        }

        public void fillEditOptionComment()
        {
            foreach (int optionCommentEditElement in editTemplate.opID)
            {
                DBConnection.getDBConnectionToInstance().fillOptionComment(Constants.SQLFillEditOptionTitle, optionCommentEditElement);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            wasChanged();
            cleanStart();
            this.Close();
        }

        public void wasChanged()
        {
            if ((string)TemplateNameTextboxData.Tag != TemplateNameTextboxData.Text)
            {
                DBConnection.getDBConnectionToInstance().updateTemp(Constants.SQLUpdateTemplate, editTemplate.tempEditID);
            }

            if ((string)TemplateReviewerTextboxData.Tag != TemplateReviewerTextboxData.Text)
            {
                DBConnection.getDBConnectionToInstance().updateTempReviewer(Constants.SQLUpdateTemplateReviewer, editTemplate.tempEditID);
            }

            if ((string)TemplatePositionTextboxData.Tag != TemplatePositionTextboxData.Text)
            {
                DBConnection.getDBConnectionToInstance().updateTempPosition(Constants.SQLUpdateTemplatePosition, editTemplate.tempEditID);
            }

            foreach (int update in editTemplate.sectID)
            {
                if ((string)sectionTitleTextboxData[DBConnection.updateSectionTitleIndex].Tag != sectionTitleTextboxData[DBConnection.updateSectionTitleIndex].Text)
                {
                    DBConnection.getDBConnectionToInstance().updateSectionTitle(Constants.SQLUpdateSectionTitle, update);
                    DBConnection.updateSectionTitleIndex += 1;
                }
                else
                {
                    DBConnection.updateSectionTitleIndex += 1;
                }
            }

            foreach (int update in editTemplate.opID)
            {
                if ((string)optionTitleTextboxData[DBConnection.updateOptionTitleIndex].Tag != optionTitleTextboxData[DBConnection.updateOptionTitleIndex].Text)
                {
                    DBConnection.getDBConnectionToInstance().updateOptionsTitle(Constants.SQLUpdateOptionsTitle, update);
                    DBConnection.updateOptionTitleIndex += 1;
                }
                else
                {
                    DBConnection.updateOptionTitleIndex += 1;
                }
            }

            foreach (int update in editTemplate.opID)
            {
                if ((string)optionCommentTextboxData[DBConnection.updateCommentIndex].Tag != optionCommentTextboxData[DBConnection.updateCommentIndex].Text)
                {
                    DBConnection.getDBConnectionToInstance().updateOptionsComment(Constants.SQLUpdateOptionsComment, update);
                    DBConnection.updateCommentIndex += 1;
                }
                else
                {
                    DBConnection.updateCommentIndex += 1;
                }
            }
        }

        public void cleanStart()
        {
            sectionTitleTextbox.Clear();
            sectionTitleTextboxData.Clear();

            optionTitleTextbox.Clear();
            optionTitleTextboxData.Clear();

            optionCommentTextbox.Clear();
            optionCommentTextboxData.Clear();

            TemplateNameTextbox.Clear();
            TemplateNameTextboxData.Clear();

            TemplateReviewerTextbox.Clear();
            TemplateReviewerTextboxData.Clear();

            TemplatePositionTextbox.Clear();
            TemplatePositionTextboxData.Clear();

            sectionTitleNum = 126;
            sectionTitleDataNum = 126;
            optionTitleNum = 152;
            optionTitleDataNum = 152;
            optionCommentNum = 197;
            optionCommentNumData = 178;

            sectionTextBoxCount = 0;
            optionsTextBoxCount = 0;

            editTemplate.opID.Clear();
            editTemplate.sectID.Clear();
            editTemplate.tempEditID = 0;
            editTemplate.templateEditName = null;

            DBConnection.optionOriginalEditID.Clear();
            DBConnection.updateSectionTitleIndex = 0;
            DBConnection.sectOriginalEditID.Clear();
            DBConnection.fillSectionIndex = 0;
            DBConnection.optionTitleIndex = 0;
            DBConnection.optionCommentIndex = 0;

            DBConnection.updateOptionTitleIndex = 0;
            DBConnection.updateCommentIndex = 0;

        }
    }
}
