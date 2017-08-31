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
    public partial class removeTemplateWarning : Form
    {
        public removeTemplateWarning()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            removeTemplate remove = new removeTemplate();
            remove.getLatestRemoveTemplateID();
            remove.getLatestRemoveSectionID();
            remove.getLastestRemoveOptionsID();
            remove.removeChosenTemplate();
            this.Close();
        }
    }
}
