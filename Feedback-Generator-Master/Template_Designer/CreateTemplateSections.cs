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
    public partial class CreateTemplateSections : Form
    {     

        public object TitleBox { get; private set; }
        public object CommentsBox { get; private set; }

        public CreateTemplateSections()
        {
            InitializeComponent();                           
        }

        private void newSectionButton_Click(object sender, EventArgs e)
        {            
            Close();
            enterSectionTitle sectionTitleEnter = new enterSectionTitle();
            sectionTitleEnter.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {    

        }  

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            CreateNewOptions input = new CreateNewOptions();
            input.getLatestsectionID();
            input.addOptionTitle(titleTextBox.Text);
            input.addOptionComment(commentTextBox.Text);
            input.writeOptionDetailsToDB();
            Close();
            CreateTemplateSections reOpen = new CreateTemplateSections();
            reOpen.Show();
            
        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {
            //options title text box
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            //options comment text box
        }
    }

}
