using KKzuPersonErweiterungCSVundDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CSVLeserKonsole
{
    internal class DBParser : IParser
    {
        //truncate angucken

        string myConnectionString = "SERVER=192.168.178.207;" +
                                    "DATABASE=db_uebung;" +
                                    "UID=Admin;" +
                                    "PASSWORD=P@ssw0rd;";

        public List<Person> LoadPersonenListe()
        {
            List<Person> personenListe = new List<Person>();

            MySqlConnection connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Person;";
            MySqlDataReader reader;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int _id = Int32.Parse(reader.GetString("id"));
                    // alternativ t_person.ID = reader.GetInt32("id");
                    string _vorname = reader.GetString("vorname");
                    string _nachname = reader.GetString("nachname");
                    string _strasse = reader.GetString("strasse");
                    string _hausNr = reader.GetString("hausnr");
                    string _plz = reader.GetString("plz");
                    string _ort= reader.GetString("ort");
                    string _land = reader.GetString("land");
                    string _telefonnr = reader.GetString("telefonnr");
                    Person t_person = new Person(_id,_vorname,_nachname,_strasse,_hausNr,_plz,_ort,_land,_telefonnr);
                    personenListe.Add(t_person);
                }
                connection.Close();
                return personenListe;
            }
            catch (Exception)
            {

                throw;
            }
        }        
        public void NeuePersonAnlegen(Person t_person)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            string myInsertQuery = "INSERT INTO Person (vorname, nachname, strasse, hausnr, plz, ort, land, telefonnr) " +
                                   "Values('" + t_person.Vorname + "','" + t_person.Nachname + "','" + t_person.Strasse + "','" +
                                   t_person.HausNr + "','" + t_person.PLZ + "','" + t_person.Ort + "','" + t_person.Land +
                                   "','" + t_person.TelefonNr + "');";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = connection;
            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdatePerson(Person t_person)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            string myUpdateQuery = "UPDATE Person SET vorname = '" + t_person.Vorname + "', nachname = '" + t_person.Nachname +
                                   "', strasse = '" + t_person.Strasse + "', hausnr = '" + t_person.HausNr + "', plz = '" + t_person.PLZ +
                                   "', ort = '" + t_person.Ort + "', land = '" + t_person.Land + "', telefonnr = '" + t_person.TelefonNr + "' WHERE id = " + t_person.ID + ";";

            MySqlCommand myCommand = new MySqlCommand(myUpdateQuery);
            myCommand.Connection = connection;
            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeletePerson(Person t_person)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            string myDeleteQuery = "DELETE from Person WHERE id = " + t_person.ID + ";";

            MySqlCommand myCommand = new MySqlCommand(myDeleteQuery);
            myCommand.Connection = connection;
            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletePerson(int t_int)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            string myDeleteQuery = "DELETE from Person WHERE id = " + t_int + ";";

            MySqlCommand myCommand = new MySqlCommand(myDeleteQuery);
            myCommand.Connection = connection;
            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ListeSpeichern(List<Person> _list)
        {
            MySqlConnection connection = new MySqlConnection(myConnectionString);
            string myDropQuery = "DROP TABLE Person;";
            MySqlCommand myCommand = new MySqlCommand(myDropQuery);
            myCommand.Connection = connection;
            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();
            }
            catch (Exception) { throw; }

            string myCreateQuery = "CREATE TABLE `Person` (`ID` INT NOT NULL AUTO_INCREMENT,`Vorname` VARCHAR(45) NULL,`Nachname` VARCHAR(45) NULL," +
                "`Strasse` VARCHAR(45) NULL,`HausNr` VARCHAR(45) NULL,`PLZ` VARCHAR(45) NULL,`Ort` VARCHAR(45) NULL,`Land` VARCHAR(45) NULL," +
                "`TelefonNr` VARCHAR(45) NULL, PRIMARY KEY (`ID`),UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE);";
            MySqlCommand mycreateCommand = new MySqlCommand(myCreateQuery);
            mycreateCommand.Connection = connection;
            try
            {
                connection.Open();
                mycreateCommand.ExecuteNonQuery();
                mycreateCommand.Connection.Close();
            }
            catch (Exception) { throw; }

            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].ID != 0)
                {
                    string myInsertQuery = "INSERT INTO Person (id, vorname, nachname, strasse, hausnr, plz, ort, land, telefonnr) " +
                                   "Values('" + _list[i].ID + "','" + _list[i].Vorname + "','" + _list[i].Nachname + "','" + _list[i].Strasse + "','" +
                                   _list[i].HausNr + "','" + _list[i].PLZ + "','" + _list[i].Ort + "','" + _list[i].Land +
                                   "','" + _list[i].TelefonNr + "');";

                    MySqlCommand myInsert = new MySqlCommand(myInsertQuery);
                    myInsert.Connection = connection;
                    try
                    {
                        connection.Open();
                        myInsert.ExecuteNonQuery();
                        myInsert.Connection.Close();
                    }
                    catch (Exception) { throw; }
                }
                else
                {
                    string myInsertQuery = "INSERT INTO Person (vorname, nachname, strasse, hausnr, plz, ort, land, telefonnr) " +
                                   "Values('" + _list[i].Vorname + "','" + _list[i].Nachname + "','" + _list[i].Strasse + "','" +
                                   _list[i].HausNr + "','" + _list[i].PLZ + "','" + _list[i].Ort + "','" + _list[i].Land +
                                   "','" + _list[i].TelefonNr + "');";

                    MySqlCommand myInsert = new MySqlCommand(myInsertQuery);
                    myInsert.Connection = connection;
                    try
                    {
                        connection.Open();
                        myInsert.ExecuteNonQuery();
                        myInsert.Connection.Close();
                    }
                    catch (Exception) { throw; }
                }
            }

        }
    }
}
