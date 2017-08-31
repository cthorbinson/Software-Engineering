using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    class editTemplate
    {
        public static string templateEditName;
        public static int tempEditID = 0;
        public static List<int> sectID = new List<int>();
        public static List<int> opID = new List<int>();

        public void addEditTemplateName(string templateName)
        {
            templateEditName = templateName;
        }

        public void getLatestEditTemplateID()
        {
            DBConnection.getDBConnectionToInstance().getEditTemplateID(Constants.getEditTemplateID, templateEditName);
        }

        public void turn_to_Edit_ID(int tempID)
        {
            tempEditID = tempID;
        }

        public void getLatestEditSectionID()
        {
            DBConnection.getDBConnectionToInstance().getEditSectionID(Constants.getEditSectionID, tempEditID);
        }

        public void turn_to_Edit_Section_ID(List<int> tempSectID)
        {
            sectID = tempSectID;
        }

        public void getLastestEditOptionsID()
        {
            foreach (int EditoptionIDElement in sectID)
            {
                int temporarySectEditId = EditoptionIDElement;
                DBConnection.getDBConnectionToInstance().getEditOptionId(Constants.getEditOptionID, temporarySectEditId);
            }
        }

        public void turn_to_Edit_Option_ID(List<int> tempOptionID)
        {
            opID = tempOptionID;
        }
    }
}
