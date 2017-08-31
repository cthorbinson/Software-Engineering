using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Designer
{
    /// <summary>
    /// Name: Constants
    /// Description: Class to store all required SQL Statements. 
    /// </summary>
    class Constants
    {
        //INSERT SQL Statements
        public static String Insert = "INSERT INTO createTemplate(templateName, templateReviewer, templatePosition) VALUES(@templateNameOne, @templateReviewerOne, @templatePositionOne)";
        public static String InsertOption = "INSERT INTO createTemplateOptions(optionsTitle, optionsComment, sectionsID) VALUES(@optionTitleOne, @optionCommentOne, @secID)";
        public static String InsertSectionName = "INSERT INTO createTemplateSections(sectionTitle, templateID) VALUES(@sectionNameOne, @templateID)";

        //SELECT SQL Statements
        public static String getTempTemplateID = "SELECT templateID FROM createTemplate WHERE templateID IN (SELECT MAX(templateID) FROM createTemplate)";
        public static String getSectionsID = "SELECT sectionID FROM createTemplateSections WHERE sectionID IN (SELECT MAX(sectionID) FROM createTemplateSections)";

        //SELECT SQL Statements for removing templates
        public static string getRemoveTemplateID = "SELECT templateID FROM createTemplate WHERE templateName = @templateRemoveName";
        public static string getRemoveSectionID = "SELECT sectionID FROM createTemplateSections WHERE templateID = @tempID";
        public static string getRemoveOptionID = "SELECT optionsID FROM createTemplateOptions WHERE sectionsID = @temporarySectId";

        //DELETE SQL Statements to remove the templates
        public static string RemoveOption = "DELETE FROM createTemplateOptions WHERE optionsID = @optionElement";
        public static string RemoveSection = "DELETE FROM createTemplateSections WHERE sectionID = @sectionElement";
        public static string RemoveTemplate = "DELETE FROM createTemplate WHERE templateID = @tempID";

        //SELECT SQL Statements for editing templates
        public static string getEditTemplateID = "SELECT templateID FROM createTemplate WHERE templateName = @templateEditName";
        public static string getEditSectionID = "SELECT sectionID FROM createTemplateSections WHERE templateID = @tempEditID";
        public static string getEditOptionID = "SELECT optionsID FROM createTemplateOptions WHERE sectionsID = @temporarySectEditId";

        //SELECT SQL statements to fill in the edit menus textboxes
        public static string SQLFillEditTemplate = "SELECT * FROM createTemplate WHERE templateID = @tempEditID";
        public static string SQLFillEditSection = "SELECT * FROM createTemplateSections WHERE templateID = @tempEditID";
        public static string SQLFillEditOptionTitle = "SELECT * FROM createTemplateOptions WHERE optionsID = @opID";

        public static string SQLCreateEditSection = "SELECT * FROM createTemplatesections WHERE templateID = @tempEditID";
        public static string SQLCreateEditOption = "SELECT * FROM createTemplateOptions WHERE sectionsID = @sectID";

        public static string SQLUpdateTemplate = "UPDATE createTemplate SET templateName = @NewTempName WHERE templateID = @tempEditID";
        public static string SQLUpdateTemplateReviewer = "UPDATE createTemplate SET templateReviewer = @NewTempReviewer WHERE templateID = @tempEditID";
        public static string SQLUpdateTemplatePosition = "UPDATE createTemplate SET templatePosition = @NewTempPosition WHERE templateID = @tempEditID";
        public static string SQLUpdateSectionTitle = "UPDATE createTemplateSections SET sectionTitle = @NewSectionTitle WHERE sectionID = @sectID";
        
        public static string SQLUpdateOptionsTitle = "UPDATE createTemplateOptions SET optionsTitle = @NewOptionTitle WHERE optionsID = @opID";
        public static string SQLUpdateOptionsComment = "UPDATE createTemplateOptions SET optionsComment = @NewOptionComment WHERE optionsID = @opID";
    }
}
