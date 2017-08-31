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
    public partial class TemplateSelector : Form
    {
        public TemplateSelector()
        {
            InitializeComponent();
        }
        // When create new template button clicked: open 'CreateTemplate' class
        private void createNewTemplate_button_Click(object sender, EventArgs e)
        {
            CreateTemplate CT = new CreateTemplate();
            CT.ShowDialog();
        }

        private void TemplateSelector_Load(object sender, EventArgs e)
        {
            DataSet clDs = DBConnection.getDBConnectionToInstance().getDataSet("SELECT templateName FROM createTemplate");
            cbCl.DataSource = clDs.Tables[0];
            cbCl.DisplayMember = "templateName";
            // TODO: This line of code loads data into the 'templateNameDataSet.createTemplate' table. You can move, or remove it, as needed.
            this.createTemplateTableAdapter.Fill(this.templateNameDataSet.createTemplate);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            editTemplate edit = new editTemplate();
            editMenu fillEdit = new editMenu();
            edit.addEditTemplateName(cbCl.Text);
            edit.getLatestEditTemplateID();
            edit.getLatestEditSectionID();
            edit.getLastestEditOptionsID();
            fillEdit.createTBEditTemplate();
            fillEdit.fillEditTemplate();
            fillEdit.fillEditSection();
            fillEdit.fillEditOption();
            fillEdit.fillEditOptionComment();
            fillEdit.ShowDialog();
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            removeTemplate remove = new removeTemplate();
            removeTemplateWarning removeWarning = new removeTemplateWarning();
            remove.addTemplateName(cbCl.Text);
            removeWarning.ShowDialog();
        }

        public void TemplateSelector_GotFocus(object sender, EventArgs e)
        {
           DataSet clDs = DBConnection.getDBConnectionToInstance().getDataSet("SELECT TemplateName FROM CreateTemplate");
           cbCl.DataSource = clDs.Tables[0];
           cbCl.DisplayMember = "templateName";
         }   
    }
}
