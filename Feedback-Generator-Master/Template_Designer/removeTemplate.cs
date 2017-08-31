using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    class removeTemplate
    {
        private static string templateRemoveName;
        public static int tempID = 0;
        public static List<int> sectID = new List<int>();
        public static List<int> opID = new List<int>();

        public void addTemplateName(string templateName)
        {
            templateRemoveName = templateName;
        }

        public void turn_to_Remove_ID(int tempTemplateID)
        {
            tempID = tempTemplateID;
        }

        public void turn_to_Remove_Section_ID(List<int> tempSectionID)
        {
            sectID = tempSectionID;
        }
        public void turn_to_Remove_Option_ID(List<int> tempOptionID)
        {
            opID = tempOptionID;
        }

        public void getLatestRemoveTemplateID()
        {
            DBConnection.getDBConnectionToInstance().getRemoveTemplateID(Constants.getRemoveTemplateID, templateRemoveName);
        }

        public void getLatestRemoveSectionID()
        {
            DBConnection.getDBConnectionToInstance().getRemoveSectionID(Constants.getRemoveSectionID, tempID);
        }

        public void getLastestRemoveOptionsID()
        {
            foreach (int optionIDElement in sectID)
            {
                int temporarySectId = optionIDElement;
                DBConnection.getDBConnectionToInstance().getRemoveOptionId(Constants.getRemoveOptionID, temporarySectId);
            }
        }

        public void removeChosenTemplate()
        {
            foreach (int optionElement in opID)
            {
                DBConnection.getDBConnectionToInstance().removeOption(Constants.RemoveOption, optionElement);
            }

            foreach (int sectionElement in sectID)
            {
                DBConnection.getDBConnectionToInstance().removeSection(Constants.RemoveSection, sectionElement);
            }

            DBConnection.getDBConnectionToInstance().removeTemplate(Constants.RemoveTemplate, tempID);
        }
    }
}
