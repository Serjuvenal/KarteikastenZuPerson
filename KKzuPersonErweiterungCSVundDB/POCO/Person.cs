namespace KKzuPersonErweiterungCSVundDB
{
    internal class Person
    {
        public Person(int t_id, string t_vorname, string t_nachname, string t_strasse, string t_hausnr,
            string t_plz, string t_ort, string t_land, string t_telefonnumer)
        {
            ID = t_id;
            Vorname = t_vorname;
            Nachname = t_nachname;
            Strasse = t_strasse;
            HausNr = t_hausnr;
            PLZ = t_plz;
            Ort = t_ort;
            Land = t_land;
            TelefonNr = t_telefonnumer;
        }

        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string HausNr { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }
        public string TelefonNr { get; set; }
    }
}
