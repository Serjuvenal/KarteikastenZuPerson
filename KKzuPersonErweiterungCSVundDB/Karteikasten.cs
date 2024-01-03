using CSVLeserKonsole;
using System.Windows.Forms;

namespace KKzuPersonErweiterungCSVundDB
{
    public partial class Karteikasten : Form
    {
        private IParser _myDBParser = new DBParser();
        private IParser _myCSVParser = new CSVParser();

        private List<Person> _aktuelleListe = new List<Person>();
        private List<Person> _listezumloeschen = new List<Person>();
        private List<Person> _listezumaktualisieren = new List<Person>();
        private List<Person> _listezumanlegen = new List<Person>();

        private int _myindex = -1;
        private bool _istListegeladen = false;
        private bool _listesortiert = false;


        public Karteikasten()
        {
            InitializeComponent();
        }
        private void Karteikasten_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        #region TSB ToolStripBar 
        private void tsb_ListeLoadDB_Click(object sender, EventArgs e)
        {
            _aktuelleListe = _myDBParser.LoadPersonenListe();
            _istListegeladen = true;
            _myindex = 0;
            DGVAktualisieren();
            PersonZeigen();
        }
        private void tsb_ListeSpeichernDB_Click(object sender, EventArgs e)
        {
            // mit 3 listen arbeiten? Liste zum loeschen, Liste zum aktualisieren, Liste zum neue Personen hinzufügen...

            if (_istListegeladen)
            {
                foreach (var t_person in _listezumloeschen)
                {
                    _myDBParser.DeletePerson(t_person);
                }

                foreach (var t_person in _listezumaktualisieren)
                {
                    _myDBParser.UpdatePerson(t_person);
                }

                foreach (var t_person in _listezumanlegen)
                {
                    _myDBParser.NeuePersonAnlegen(t_person);
                }
            }
            ListeEntleeren();
            DGVAktualisieren();

            tsb_ListeLoadDB_Click(sender, e);
        }
        private void tsb_ListeLoadCSV_Click(object sender, EventArgs e)
        {
            _aktuelleListe = _myCSVParser.LoadPersonenListe();
            _istListegeladen = true;
            DGVAktualisieren();
            _myindex = 0;
            PersonZeigen();
        }
        private void tsb_ListeSpeichernCSV_Click(object sender, EventArgs e)
        {
            _myCSVParser.ListeSpeichern(_aktuelleListe);
            ListeEntleeren();
            _istListegeladen = false;
            DGVAktualisieren();
        }
        private void tsb_neuePerson_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                TBsLeeren();
                tb_id.Text = "0";
                tb_id.Enabled = false;
            }
            else
            {
                MessageBox.Show("Um eine neue Person einlegen, muss erst eine Zielliste geladen werden", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void tsb_Personhinzufuegen_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                if (tb_vorname.Text != "" && tb_nachname.Text != "" && tb_strasse.Text != "" && tb_hausnummer.Text != "" && tb_postleitzahl.Text != "" && tb_wohnort.Text != "" && tb_land.Text != "" && tb_telefonnummer.Text != "")
                {
                    Person t_newperson = PersonBilden();
                    if (Dublettencheck(t_newperson))
                    {
                        MessageBox.Show("Den Eintrag existiert schon in der Liste", "Fehler", MessageBoxButtons.OK);
                    }
                    else
                    {
                        _aktuelleListe.Add(t_newperson);
                        _listezumanlegen.Add(t_newperson);
                        DGVAktualisieren();
                    }
                    MessageBox.Show("Person an die Liste hinzugefügt", "Congratz!", MessageBoxButtons.OK);

                    tb_id.Enabled = true;
                    TBsLeeren();
                }
                else
                {
                    MessageBox.Show("Bitte alle Felder auffühlen", "Fehler", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Um eine neue Person einlegen, muss erst eine Zielliste geladen werden", "Fehler", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Liste bearbeiten buttons
        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                _myindex -= 1;
                if (_myindex >= 0)
                {
                    PersonZeigen();
                }
                else if (_myindex < 0)
                {
                    MessageBox.Show("Erste Eintrag in Dokument", "Fehler", MessageBoxButtons.OK);
                    _myindex = 0;
                }
                //else
                //    PersonZeigen();
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                _myindex += 1;
                if (_myindex < _aktuelleListe.Count - 1)
                {
                    PersonZeigen();
                }
                else
                {
                    MessageBox.Show("Letzte Eintrag in Dokument", "Fehler", MessageBoxButtons.OK);
                    _myindex = _aktuelleListe.Count - 1;
                    PersonZeigen();
                }
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void btn_updaten_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                if (_myindex != -1)
                {
                    //ID MUSSTE nicht verändert werden
                    _aktuelleListe[Convert.ToInt32(_myindex)].Vorname = tb_vorname.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].Nachname = tb_nachname.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].Strasse = tb_strasse.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].HausNr = tb_hausnummer.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].PLZ = tb_postleitzahl.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].Ort = tb_wohnort.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].Land = tb_land.Text;
                    _aktuelleListe[Convert.ToInt32(_myindex)].TelefonNr = tb_telefonnummer.Text;

                    _listezumaktualisieren.Add(_aktuelleListe[_myindex]);

                    _myindex = -1;
                }
                else
                {
                    MessageBox.Show("Du hast kein Person ID ausgewählt", "Fehler", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
            DGVAktualisieren();
        }
        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                _listezumloeschen.Add(_aktuelleListe[_myindex]);
                _aktuelleListe.RemoveAt(_myindex);
                DGVAktualisieren();
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
            TBsLeeren();
            _myindex = -1;
        }
        private void btn_nachID_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                if (_listesortiert)
                {
                    _aktuelleListe = _aktuelleListe.OrderByDescending(Person => Person.ID).ToList();
                    _listesortiert = false;
                }
                else
                {
                    _aktuelleListe = _aktuelleListe.OrderBy(Person => Person.ID).ToList();
                    _listesortiert = true;
                }
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void btn_nachname_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                if (_listesortiert)
                {
                    _aktuelleListe = _aktuelleListe.OrderByDescending(Person => Person.Nachname).ToList();
                    _listesortiert = false;
                }
                else
                {
                    _aktuelleListe = _aktuelleListe.OrderBy(Person => Person.Nachname).ToList();
                    _listesortiert = true;
                }
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void btn_nachplz_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                if (_listesortiert)
                {
                    _aktuelleListe = _aktuelleListe.OrderByDescending(Person => Person.PLZ).ToList();
                    _listesortiert = false;
                }
                else
                {
                    _aktuelleListe = _aktuelleListe.OrderBy(Person => Person.PLZ).ToList();
                    _listesortiert = true;
                }
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }
        }
        private void btn_nachOrt_Click(object sender, EventArgs e)
        {
            if (_istListegeladen)
            {
                if (_listesortiert)
                {
                    _aktuelleListe = _aktuelleListe.OrderByDescending(Person => Person.Ort).ToList();
                    _listesortiert = false;
                }
                else
                {
                    _aktuelleListe = _aktuelleListe.OrderBy(Person => Person.Ort).ToList();
                    _listesortiert = true;
                }
            }
            else
            {
                MessageBox.Show("Keine Liste geladen", "Fehler", MessageBoxButtons.OK);
            }

        }
        #endregion

        #region DataGridView
        private void dgv_personen_Click(object sender, EventArgs e)
        {
            _myindex = dgv_personen.CurrentCell.RowIndex;
            PersonZeigen();
        }
        private void DGVAktualisieren()
        {
            dgv_personen.DataSource = null;
            dgv_personen.DataSource = _aktuelleListe;
        }
        #endregion


        #region T I M E R
        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //}
        #endregion

        #region Tools Methoden
        private void TBsLeeren()
        {
            _myindex = -1;
            tb_id.Text = "";
            tb_vorname.Text = "";
            tb_nachname.Text = "";
            tb_strasse.Text = "";
            tb_hausnummer.Text = "";
            tb_postleitzahl.Text = "";
            tb_wohnort.Text = "";
            tb_land.Text = "";
            tb_telefonnummer.Text = "";
        }
        private bool Dublettencheck(Person _person)
        {
            int treffer = 0;
            for (int i = 0; i < _aktuelleListe.Count; i++)
            {
                if (_person.Vorname.ToLower() == _aktuelleListe[i].Vorname.ToLower() && _person.Nachname.ToLower() == _aktuelleListe[i].Nachname.ToLower()
                    && _person.Strasse.ToLower() == _aktuelleListe[i].Strasse.ToLower() && _person.Ort == _aktuelleListe[i].Ort && _person.TelefonNr == _aktuelleListe[i].TelefonNr)
                {
                    treffer++;
                }
            }
            if (treffer > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Person PersonBilden()
        {
            Person newperson = new Person(0, tb_vorname.Text, tb_nachname.Text, tb_strasse.Text, tb_hausnummer.Text, tb_postleitzahl.Text, tb_wohnort.Text, tb_land.Text, tb_telefonnummer.Text);
            return newperson;
        }
        private void PersonZeigen()
        {
            tb_id.Text = _aktuelleListe[_myindex].ID.ToString();
            tb_vorname.Text = _aktuelleListe[_myindex].Vorname;
            tb_nachname.Text = _aktuelleListe[_myindex].Nachname;
            tb_strasse.Text = _aktuelleListe[_myindex].Strasse;
            tb_hausnummer.Text = _aktuelleListe[_myindex].HausNr;
            tb_postleitzahl.Text = _aktuelleListe[_myindex].PLZ;
            tb_wohnort.Text = _aktuelleListe[_myindex].Ort;
            tb_land.Text = _aktuelleListe[_myindex].Land;
            tb_telefonnummer.Text = _aktuelleListe[_myindex].TelefonNr;
        }
        private void ListeEntleeren()
        {
            _aktuelleListe.Clear();
            _listezumanlegen.Clear();
            _listezumloeschen.Clear();
            _listezumaktualisieren.Clear();
        }
        #endregion
    }
}