using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    /// <summary>
    /// Name: addToSection Class
    /// Description: addToSection Class takes the user input from the User Interface and inputs it into the Section Table.
    ///              Code also links Section Table to TemplateID Table by creating a Forgeign Key.
    /// </summary>
    class addToSection
    {
        //Initalise Class Variables.
        public string sectionNameOne;
        public static int tempID = 0;

        //addSectionName takes the User Input and adds it to the Class Variable.
        public void addSectionName(string addSectionName)
        {
            sectionNameOne = addSectionName;
        }

        //turn_to_ID takes the TemplateID adding it to the Class Variable.
        public int turn_to_ID(int ID)
        {
            tempID = ID;
            return tempID;
        }

        //getLatestTemplateID Runs the getTemplateID SQL Statement with DB Conenction Instance
        public void getLatestTemplateID()
        {
            DBConnection.getDBConnectionToInstance().getTempTemplateID(Constants.getTempTemplateID);
        }

        //writeNameToDB Runs the InsertSectioName SQL Statement to Insert Section Name and Template ID to table
        public void writeNameToDB()
        {
            DBConnection.getDBConnectionToInstance().insertSectionTitle(Constants.InsertSectionName, sectionNameOne, tempID);
        }
    }
}
