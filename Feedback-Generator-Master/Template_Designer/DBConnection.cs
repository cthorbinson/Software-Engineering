using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Template_Designer
{
    /// <summary>
    /// Name: DBConnection
    /// Description: DBConnection links the Database to the program. 
    ///
    class DBConnection
    {
        //Set Attributes
        private static DBConnection _instance;

        private static string connectionStr;

        private System.Data.SqlClient.SqlConnection connectionToDB;

        private System.Data.SqlClient.SqlDataAdapter dataAdapter;

        //Constructors

        //Properties
        public static string ConnectionStr
        {
            set
            {
                connectionStr = value;
            }
        }

        //Methods

        //Return the connection to the database
        public static DBConnection getDBConnectionToInstance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        //Open Database connection
        public void openConnection()
        {
            connectionToDB = new System.Data.SqlClient.SqlConnection(connectionStr);
            connectionToDB.Open();
        }

        //Closes Database Connection
        public void closeConnection()
        {
            connectionToDB.Close();
        }

        //Sets Database Instance to connectionStr Variable.
        public string instance()
        {
            return connectionStr;
        }


        //Inserts the name, position and reviewer of the new template
        public void insertTemplate(string sqlQuery, string tempName, string tempReviewer, string tempPos)
        {
            //creates a connection to the sql command, converting the sql as text
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds Variables into SQL Statement
            command.Parameters.Add("templateNameOne", tempName);
            command.Parameters.Add("templateReviewerOne", tempReviewer);
            command.Parameters.Add("templatePositionOne", tempPos);

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes the sql statement
            command.ExecuteNonQuery();

            //Closes the connection
            closeConnection();
        }

        //A method to insert the section name and the current template ID
        public void insertSectionTitle(string sqlQuery, string tempSection, int tempID)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds Variables into SQL Statement
            command.Parameters.AddWithValue("@templateID", tempID);
            command.Parameters.AddWithValue("@sectionNameOne", tempSection);

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes the SQL Query.
            command.ExecuteNonQuery();

            //command.Connection.Close();
            closeConnection();
        }

        //A method that gets the lastest Template ID, which will be used as a foriegn key for the section table
        public void getTempTemplateID(string sqlQuery)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            addToSection getID = new addToSection();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //executes the sql statement and parses the template ID as a interger
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());

            //calls the method to pass the ID variable to the secID from createTemplate
            getID.turn_to_ID(ID);

            //Closes the Database Connection.
            closeConnection();
        }

        //A method that gets the lastest section ID to act as a foreign key for options table
        public void getSectioneID(string sqlQuery)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            CreateNewOptions getSecID = new CreateNewOptions();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //Executes SQL Query and enters the output into Variable.
            int ID = Convert.ToInt32(command.ExecuteScalar().ToString());

            //calls the method to pass the ID variable to the secID from SectionID.
            getSecID.turn_to_SecID(ID);

            //Closes Database Connection
            closeConnection();
        }

        // Get the data set generated by the sqlStatement
        public System.Data.DataSet getDataSet(string sqlStatement)
        {
            //Opens Connection to the Database.
            openConnection();

            //Creates a new DataSet.
            System.Data.DataSet dataSet;

            // create the object dataAdapter to manipulate a table from the database StudentDissertations specified by connectionToDB
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlStatement, connectionToDB);

            // create the dataset
            dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);

            //Closes the Connection
            closeConnection();

            //return the dataSet
            return dataSet;
        }

        //A method to Insert Titles and Comments into Database.
        public void insertOption(string sqlQuery, string tempTitle, string tempComment, int tempSecID)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds Options to SQL Query.
            command.Parameters.AddWithValue("@secID", tempSecID);
            command.Parameters.Add("optionTitleOne", tempTitle);
            command.Parameters.Add("optionCommentOne", tempComment);

            //Opens the Connection to the Database.
            openConnection();

            //Executes the SQL Command.
            command.Connection = connectionToDB;
            command.ExecuteNonQuery();

            //Closes the Connection to the Database.
            closeConnection();
        }

        /* The next 6 methods are to get the ID's of a template that the user selected,
         * and then deletes the rows associatied with the ID's from bottom to top
         * (options -> section -> template)*/

        //Gets the templateID of the template that the user wants removed
        public void getRemoveTemplateID(string sqlQuery, string Rname)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            removeTemplate getID = new removeTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //adds the template name to the parameters.
            command.Parameters.AddWithValue("@templateRemoveName", Rname);

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //executes the sql statement. The sql statement will find the TempId based on the name association
            int ID = Convert.ToInt32(command.ExecuteScalar());

            //calls the method to pass the ID variable to the tempID from the removeTemplate
            getID.turn_to_Remove_ID(ID);

            //Closes the Database Connection.
            closeConnection();
        }

        //creates a temporary list that contains the sections ID. will be used to set sectID list in removeTemplate
        public static List<int> sectOriginalID = new List<int>();

        //Gets the section ID of the user chosen template
        public void getRemoveSectionID(string sqlQuery, int TID)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            removeTemplate getID = new removeTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds the tempateID to the parameters
            command.Parameters.AddWithValue("@tempID", TID);

            //open the connection
            openConnection();
            command.Connection = connectionToDB;

            /*Performs a command that reads the database and finds rows that fits the condition of the sql statement
              the execution of the command itself will be used to find and add the section ID's to the sectID list*/
            using (SqlDataReader reader = command.ExecuteReader())
            {
                /*the read command performs sequentially. When the row is found that fits the conditions of the sql statement,
                  add that sectionID to the temporary list*/
                while (reader.Read())
                {
                    sectOriginalID.Add(reader.GetInt32(0));
                }
            }

            //Closes the Database Connection.
            closeConnection();

            //turns the sectID list equal the temporary list
            getID.turn_to_Remove_Section_ID(sectOriginalID);
        }

        //creates a temporary list that contains the options ID. will be used to set opID list in removeTemplate
        public static List<int> optionOriginalID = new List<int>();

        //Gets the option ID of the user chosen template
        public void getRemoveOptionId(string sqlQuery, int SID)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            removeTemplate getID = new removeTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //adds the sectionID to the command parameters
            command.Parameters.AddWithValue("@temporarySectId", SID);

            openConnection();
            command.Connection = connectionToDB;

            /*Performs a command that reads the database and finds rows that fits the condition of the sql statement
              the execution of the command itself will be used to find and add the optin ID's to the opID list*/
            using (SqlDataReader reader = command.ExecuteReader())
            {
                /*the read command performs sequentially. When the row is found that fits the conditions of the sql statement,
                  add that optionID to the temporary list*/
                while (reader.Read())
                {
                    optionOriginalID.Add(reader.GetInt32(0));
                }
            }

            //Closes the Database Connection.
            closeConnection();

            //Turns the opID list equal to the temporary list
            getID.turn_to_Remove_Option_ID(optionOriginalID);
        }

        //The method that removes the options from the databse
        public void removeOption(string sqlQuery, int OID)
        {
            ////Create SQL Command object.
            SqlCommand command = new SqlCommand();
            removeTemplate getID = new removeTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@optionElement", OID);

            openConnection();
            command.Connection = connectionToDB;

            //Execute the sql statement. This is where the options will be removed from database
            command.ExecuteNonQuery();

            closeConnection();
        }

        //The method that removes the sections from the database
        public void removeSection(string sqlQuery, int SID)
        {
            SqlCommand command = new SqlCommand();
            removeTemplate getID = new removeTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@sectionElement", SID);

            openConnection();
            command.Connection = connectionToDB;

            //Execute the sql statement. This is where the section will be removed from database
            command.ExecuteNonQuery();

            closeConnection();
        }

        //Finally, this method will remove the template from the database
        public void removeTemplate(string sqlQuery, int TID)
        {
            SqlCommand command = new SqlCommand();
            removeTemplate getID = new removeTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            command.Parameters.AddWithValue("@tempID", TID);

            openConnection();
            command.Connection = connectionToDB;

            ////Execute the sql statement. This is where the template will be removed from database
            command.ExecuteNonQuery();

            closeConnection();
        }

        /* The next 6 methods are to get the ID's of a template that the user selected,
         * and then deletes the rows associatied with the ID's from bottom to top
         * (options -> section -> template)*/
        //Gets the templateID of the template that the user wants to edit
        public void getEditTemplateID(string sqlQuery, string eName)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            editTemplate getID = new editTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //adds the template name to the parameters.
            command.Parameters.AddWithValue("@templateEditName", eName);

            //Opens Connection to the Database.
            openConnection();
            command.Connection = connectionToDB;

            //executes the sql statement. The sql statement will find the TempId based on the name association
            int ID = Convert.ToInt32(command.ExecuteScalar());

            //calls the method to pass the ID variable to the tempID from the editTemplate
            getID.turn_to_Edit_ID(ID);

            //Closes the Database Connection.
            closeConnection();
        }

        public static List<int> sectOriginalEditID = new List<int>();

        //Gets the section ID of the user chosen template
        public void getEditSectionID(string sqlQuery, int TID)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            editTemplate getID = new editTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //Adds the tempateID to the parameters
            command.Parameters.AddWithValue("@tempEditID", TID);

            //open the connection
            openConnection();
            command.Connection = connectionToDB;

            /*Performs a command that reads the database and finds rows that fits the condition of the sql statement
              the execution of the command itself will be used to find and add the section ID's to the sectID list*/
            using (SqlDataReader reader = command.ExecuteReader())
            {
                /*the read command performs sequentially. When the row is found that fits the conditions of the sql statement,
                  add that sectionID to the temporary list*/
                while (reader.Read())
                {
                    sectOriginalEditID.Add(reader.GetInt32(0));
                }
            }

            //Closes the Database Connection.
            closeConnection();

            //turns the sectID list equal the temporary list
            getID.turn_to_Edit_Section_ID(sectOriginalEditID);
        }

        public static List<int> optionOriginalEditID = new List<int>();

        //Gets the option ID of the user chosen template
        public void getEditOptionId(string sqlQuery, int SID)
        {
            //Create SQL Command object.
            SqlCommand command = new SqlCommand();
            editTemplate getID = new editTemplate();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //adds the sectionID to the command parameters
            command.Parameters.AddWithValue("@temporarySectEditId", SID);

            openConnection();
            command.Connection = connectionToDB;

            /*Performs a command that reads the database and finds rows that fits the condition of the sql statement
              the execution of the command itself will be used to find and add the optin ID's to the opID list*/
            using (SqlDataReader reader = command.ExecuteReader())
            {
                /*the read command performs sequentially. When the row is found that fits the conditions of the sql statement,
                  add that optionID to the temporary list*/
                while (reader.Read())
                {
                    optionOriginalEditID.Add(reader.GetInt32(0));
                }
            }

            //Closes the Database Connection.
            closeConnection();

            //Turns the opID list equal to the temporary list
            getID.turn_to_Edit_Option_ID(optionOriginalEditID);
        }

        public void fillTemplate(string sqlQuery, int fillTID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@tempEditID", fillTID);

            openConnection();
            command.Connection = connectionToDB;

            using (SqlDataReader fillRead = command.ExecuteReader())
            {
                while (fillRead.Read())
                {
                    editMenu.TemplateNameTextboxData.Text = (fillRead["templateName"].ToString());
                    editMenu.TemplateNameTextboxData.Tag = editMenu.TemplateNameTextboxData.Text;
                    editMenu.TemplateReviewerTextboxData.Text = (fillRead["templateReviewer"].ToString());
                    editMenu.TemplateReviewerTextboxData.Tag = editMenu.TemplateReviewerTextboxData.Text;
                    editMenu.TemplatePositionTextboxData.Text = (fillRead["templatePosition"].ToString());
                    editMenu.TemplatePositionTextboxData.Tag = editMenu.TemplatePositionTextboxData.Text;
                }
            }

            closeConnection();
        }

        public static int fillSectionIndex = 0;

        public void fillSection(string sqlQuery, int fillSID)
        {
            //Creates new DataTable (dt)
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@tempEditID", fillSID);

            openConnection();
            command.Connection = connectionToDB;

            //Set up new Data Adapter. (sqlDa)
            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            sqlDa.Fill(dt);

            foreach (TextBox fillSectionElement in editMenu.sectionTitleTextboxData)
            {
                fillSectionElement.Text = dt.Rows[fillSectionIndex]["sectionTitle"].ToString();
                fillSectionElement.Tag = fillSectionElement.Text;
                fillSectionIndex += 1;
            }   

            closeConnection();
        }

        public static int optionTitleIndex = 0;

        public void fillOptionTitle(string sqlQuery, int fillOID)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@opID", fillOID);

            openConnection();
            command.Connection = connectionToDB;

            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            sqlDa.Fill(dt);

            editMenu.optionTitleTextboxData[optionTitleIndex].Text = dt.Rows[0]["optionsTitle"].ToString();

            optionTitleIndex += 1;

            closeConnection();
        }

        public static int optionCommentIndex = 0;

        public void fillOptionComment(string sqlQuery, int fillOID)
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@opID", fillOID);

            openConnection();
            command.Connection = connectionToDB;

            SqlDataAdapter sqlDa = new SqlDataAdapter(command);
            sqlDa.Fill(dt);

            editMenu.optionCommentTextboxData[optionCommentIndex].Text = dt.Rows[0]["optionsComment"].ToString();

            optionCommentIndex += 1;

            closeConnection();
        }

        public void makeTemplateOption(string sqlQuery, int sID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            editMenu menuEdit = new editMenu();
            command.Parameters.AddWithValue("@sectID", sID);

            openConnection();
            command.Connection = connectionToDB;

            using (SqlDataReader fillRead = command.ExecuteReader())
            {
                while (fillRead.Read())
                {
                    menuEdit.createFillEditOption();
                }
            }

            closeConnection();
        }

        public void updateTemp(string sqlQuery, int TID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@tempEditID", TID);
            command.Parameters.AddWithValue("@NewTempName", editMenu.TemplateNameTextboxData.Text);

            openConnection();
            command.Connection = connectionToDB;

            command.ExecuteNonQuery();

            closeConnection();
        }

        public void updateTempReviewer(string sqlQuery, int TID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@tempEditID", TID);
            command.Parameters.AddWithValue("@NewTempReviewer", editMenu.TemplateReviewerTextboxData.Text);

            openConnection();
            command.Connection = connectionToDB;

            command.ExecuteNonQuery();

            closeConnection();
        }

        public void updateTempPosition(string sqlQuery, int TID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@tempEditID", TID);
            command.Parameters.AddWithValue("@NewTempPosition", editMenu.TemplatePositionTextboxData.Text);

            openConnection();
            command.Connection = connectionToDB;

            command.ExecuteNonQuery();

            closeConnection();
        }

        public static int updateSectionTitleIndex = 0;

        public void updateSectionTitle(string sqlQuery, int SID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@sectID", SID);
            command.Parameters.AddWithValue("@NewSectionTitle", editMenu.sectionTitleTextboxData[updateSectionTitleIndex].Text);

            openConnection();
            command.Connection = connectionToDB;

            command.ExecuteNonQuery();

            closeConnection();
        }

        public static int updateOptionTitleIndex = 0;

        public void updateOptionsTitle(string sqlQuery, int OID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@opID", OID);
            command.Parameters.AddWithValue("@NewOptionTitle", editMenu.optionTitleTextboxData[updateOptionTitleIndex].Text);

            openConnection();
            command.Connection = connectionToDB;

            command.ExecuteNonQuery();

            closeConnection();
        }

        public static int updateCommentIndex = 0;

        public void updateOptionsComment(string sqlQuery, int OID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.AddWithValue("@opID", OID);
            command.Parameters.AddWithValue("@NewOptionComment", editMenu.optionCommentTextboxData[updateCommentIndex].Text);

            openConnection();
            command.Connection = connectionToDB;

            command.ExecuteNonQuery();

            closeConnection();
        }
    }
}
