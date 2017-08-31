using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;

namespace Template_Designer
{
    /// <summary>
    /// Name: Create NewTemplate
    /// Description: Links the front end User Input to the Back End Code.
    ///   
    /// </summary>
    class CreateNewTemplate
    {
        //Creates the local variables.
        private string templateNameOne;
        private string templateReviewerOne;
        private string templatePositionOne;
        private string templateFeedbackTypeOne;

        //Methods

        //Takes Input from front end to local variable for Template Name
        public void addTemplateName(string templateNewName)
        {
            templateNameOne = templateNewName;
        }

        //Takes Input from front end to local variable for Template Reviewer
        public void addTemplateReviewer(string templateNewReviewer)
        {
            templateReviewerOne = templateNewReviewer;
        }

        //Takes Input from front end to local variable for Template Position
        public void addTemplatePosition(string templateNewPosition)
        {
            templatePositionOne = templateNewPosition;
        }

        //Takes Input from front end to local variable for Templatate Feedback Type
        public void addTemplateFeedbackType(string templateNewFeedbackType)
        {
            templateFeedbackTypeOne = templateNewFeedbackType;
        }

        //Gets the Database Connection and Runs the SQL Statement.
        public void writeTemplateDetailsToDB()
        {
            DBConnection.getDBConnectionToInstance().insertTemplate(Constants.Insert, templateNameOne, templateReviewerOne, templatePositionOne);
           
        }

    }
}

