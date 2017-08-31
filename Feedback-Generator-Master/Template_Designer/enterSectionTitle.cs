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
    public partial class enterSectionTitle : Form
    {
        public enterSectionTitle()
        {
            InitializeComponent();
        }

        private void ConfirmSectionTitleButton_Click(object sender, EventArgs e)
        {
            CreateTemplateSections cts = new CreateTemplateSections();
            addToSection input = new addToSection();
            input.getLatestTemplateID();
            input.addSectionName(sectionTitleTextbox.Text);

            input.writeNameToDB();
            Close();
            cts.Show();
        }

        private void CancelSectionTitleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sectionTitleTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
