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
    public partial class viewDatabase : Form
    {
        public viewDatabase()
        {
            InitializeComponent();
        }

        private void dataGridView1__Load(object sender, DataGridViewCellEventArgs e)
        {
            // populate the GridView
            DataSet dsPerson = DBConnection.getDBConnectionToInstance().getDataSet("SELECT * FROM createTemplate");
            //get the only table in the dataset person
            DataTable table = dsPerson.Tables[0];

            //set up the data grid view
            dataGridView1.DataSource = table;
        }

        private void viewDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feedbackGeneratorDBDataSet1.createTemplate' table. You can move, or remove it, as needed.
            this.createTemplateTableAdapter.Fill(this.feedbackGeneratorDBDataSet1.createTemplate);
            // TODO: This line of code loads data into the 'feedbackGeneratorDBDataSet.createTemplateFeedbackType' table. You can move, or remove it, as needed.
            this.createTemplateFeedbackTypeTableAdapter.Fill(this.feedbackGeneratorDBDataSet.createTemplateFeedbackType);
        }
    }
}
