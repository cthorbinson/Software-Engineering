using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    /// <summary>
    /// Name: CreateNewOptions
    /// Description: Links the front end User Input to the Back End Code.
    /// </summary>
    class CreateNewOptions
    {
        //Creates local Variables.
        private string optionTitleOne;
        private string optionCommentOne;
        public static int secID = 0;

        //Takes Input from front end to local variable for Option Title
        public void addOptionTitle(string optionNewTitle)
        {
            optionTitleOne = optionNewTitle;
        }

        //Takes Input from front end to local variable for Option Comment
        public void addOptionComment(string optionNewComment)
        {
            optionCommentOne = optionNewComment;
        }

        //Gets the SectionID and enters it into Variable
        public int turn_to_SecID(int ID)
        {
            secID = ID;
            return secID;
        }

        //Gets the Database Connection and Runs the SQL Statement.
        public void getLatestsectionID()
        {
            DBConnection.getDBConnectionToInstance().getSectioneID(Constants.getSectionsID);
        }

        //Gets the Database Connection and Runs the SQL Statement.
        public void writeOptionDetailsToDB()
        {
            DBConnection.getDBConnectionToInstance().insertOption(Constants.InsertOption, optionTitleOne, optionCommentOne, secID);
        }

        //Exception Error for Adding an Option Title.
        internal void addOptionTitle(object text)
        {
            throw new NotImplementedException();
        }
    }
}
