using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace CGDArcade_CommonLibrary
{
    public class CGDArcadeDBHandler
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string connectionString;
        private MySqlConnection mysqlConnection;

        //Initialize values
        public void InitializeValues(string server, string database, string uid, string password)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.password = password;
            this.connectionString = "SERVER=" + this.server + ";" + "DATABASE=" +
            this.database + ";" + "UID=" + this.uid + ";" + "PASSWORD=" + this.password + ";";

            CreateNewConnection();
        }

        private void CreateNewConnection()
        {
            try
            {
                this.mysqlConnection = new MySqlConnection(this.connectionString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                this.mysqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    default:
                        MessageBox.Show(ex.Message.ToString());
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                this.mysqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //  =--==--==-==--==--==-==--==--==-==--==--==-=
        //  QUERY FRAMEWORKS
        private int ExecuteQuery(string query, bool returnLastInsertID)
        {
            int lastInsertId = -1;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, this.mysqlConnection);

                //Execute command
                cmd.ExecuteNonQuery();
                if (returnLastInsertID) 
                {
                    lastInsertId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                //close connection
                this.CloseConnection();
            }
            return lastInsertId;
        }

        private MySqlDataReader ExecuteQuery(string query)
        {
            MySqlDataReader dataReader = null;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, this.mysqlConnection);

                //Execute command
                try
                {
                    //Create a data reader and Execute the command
                    dataReader = cmd.ExecuteReader();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }

                //close connection
                this.CloseConnection();
            }
            return dataReader;
        }

        private byte[] ConvertImageFileToByteArray(string filepath)
        {
            byte[] imgdata;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imgdata = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return imgdata;
        }


        //  =--==--==-==--==--==-==--==--==-==--==--==-=
        //  COLLECTION QUERIES
        public List<GenericArcadeCollection> RetrieveListOfCollections()
        {
            string query = string.Format("SELECT * FROM Collections");

            ExecuteQuery(query, false);

            //Create a list to store the result
            List<GenericArcadeCollection> arcadeCollectionList = new List<GenericArcadeCollection>();
            MySqlDataReader dataReader = ExecuteQuery(query);

            //Read the data and store them in the generic
            while (dataReader.Read())
            {
                GenericArcadeCollection newCollection = new GenericArcadeCollection();
                newCollection.id = (int)dataReader["id"];
                newCollection.collection_Title = dataReader["title"] as string;
                newCollection.collection_Description = dataReader["desc"] as string;
                newCollection.collection_ImageID = (int)dataReader["img"];
                newCollection.SetRecordSelectorText();

                arcadeCollectionList.Add(newCollection);
            }

            //close Data Reader
            dataReader.Close();
            //return list to be displayed
            return arcadeCollectionList;
        }

        public GenericArcadeCollection RetrieveCollection(string id)
        {
            string query = string.Format("SELECT * FROM Collections where id='{0}'", id);
            ExecuteQuery(query, false);

            //Create a list to store the result
            MySqlDataReader dataReader = ExecuteQuery(query);

            //Read the data and store them in the generic
            while (dataReader.Read())
            {
                GenericArcadeCollection newCollection = new GenericArcadeCollection();
                newCollection.id = (int)dataReader["id"];
                newCollection.collection_Title = dataReader["title"] as string;
                newCollection.collection_Description = dataReader["desc"] as string;
                newCollection.collection_ImageID = (int)dataReader["img"];
                newCollection.SetRecordSelectorText();
            }

            //close Data Reader
            dataReader.Close();
            //return list to be displayed
            return newCollection;
        }




        public void CreateNewCollection(string title, string desc, string filepath)
        {
            int lastInsertId;
            string query;
            if ((filepath != null) || (filepath != null))
            {
                string extn = Path.GetExtension(filepath);
                byte[] imgdata = ConvertImageFileToByteArray(filepath);
                query = string.Format("INSERT INTO Images VALUES(NULL,'{0}',{1},{2}; select last_insert_id();", extn, imgdata);
                lastInsertId = ExecuteQuery(query, true);
            }

            query = string.Format("INSERT INTO Collections VALUES(NULL,'{0}',{1},{2}", title, desc, lastInsertId);
            ExecuteQuery(query, false);
        }


        public void DeleteCollection(string id)
        {
            string query = string.Format("DELETE FROM Collections WHERE id='{0}'", extn, imgdata);
                
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.mysqlConnection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }


        }


        //  =--==--==-==--==--==-==--==--==-==--==--==-=
        //  ENTITY QUERIES










        //Insert statement
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, this.mysqlConnection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = this.mysqlConnection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, this.mysqlConnection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, this.mysqlConnection);

                MySqlDataReader dataReader;
                try
                {
                    //Create a data reader and Execute the command
                     dataReader = cmd.ExecuteReader();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return list;
                }



                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        



    }
}
