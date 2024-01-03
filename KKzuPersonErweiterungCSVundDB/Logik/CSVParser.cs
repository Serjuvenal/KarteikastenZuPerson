namespace KKzuPersonErweiterungCSVundDB
{
    internal class CSVParser : IParser
    {
        string pfad = @"C:\\Programming\\CSVDateien\Karteikasten\person.csv";

        public List<Person> LoadPersonenListe()
        {
            List<Person> t_liste = new List<Person>();
            string[] t_lines;
            string[] t_feld;

            try
            {
                t_lines = File.ReadAllLines(pfad);
                for (int i = 1; i < t_lines.Length; i++)
                {
                    t_feld = t_lines[i].Split(';');
                    int _id = Convert.ToInt32(t_feld[0]);
                    string _vorname = t_feld[1];
                    string _nachname = t_feld[2];
                    string _strasse = t_feld[3];
                    string _hausnr = t_feld[4];
                    string _plz = t_feld[5];
                    string _ort = t_feld[6];
                    string _land = t_feld[7];
                    string _telefonNr = t_feld[8];

                    Person t_person = new Person(_id, _vorname,_nachname,_strasse,_hausnr,_plz,_ort,_land,_telefonNr);
                    
                    t_liste.Add(t_person);
                }
                return t_liste;
            }
            catch (Exception) { throw; }
        }
        public void ListeSpeichern(List<Person> t_liste)
        {
            string line = "ID;Vorname;Nachname;Strasse;Hausnummer;Postleitzahl;Wohnort;Land;Telefonnummer";
            try
            {
                if (File.Exists(pfad))
                {
                    File.WriteAllText(pfad, line);
                    for (int i = 0; i < t_liste.Count; i++)
                    {
                        line = Environment.NewLine + Convert.ToString(t_liste[i].ID) + ";" + t_liste[i].Vorname + ";" + t_liste[i].Nachname + ";" + t_liste[i].Strasse + ";" + t_liste[i].HausNr + ";"
                                + t_liste[i].PLZ + ";" + t_liste[i].Ort + ";" + t_liste[i].Land + ";" + t_liste[i].TelefonNr;
                        File.AppendAllText(pfad, line);
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public void NeuePersonAnlegen(Person t_person)
        {
            try
            {
                if (File.Exists(pfad))
                {
                    string t_line = Environment.NewLine + t_person.ID + ";" + t_person.Vorname + ";" + t_person.Nachname + ";" + t_person.Strasse + ";" + t_person.HausNr + ";" + t_person.PLZ
                        + ";" + t_person.Ort + ";" + t_person.Land + ";" + t_person.TelefonNr;
                    File.AppendAllText(pfad, t_line);
                }
            } catch (Exception)
            {
                throw;
            }
        }
        public void UpdatePerson(Person t_person)
        {
            MessageBox.Show("in CSV", "UpdatePerson", MessageBoxButtons.OK);
        }
        public void DeletePerson(Person t_person)
        {
            MessageBox.Show("in CSV", "DeletePerson", MessageBoxButtons.OK);
        }
    }
}
