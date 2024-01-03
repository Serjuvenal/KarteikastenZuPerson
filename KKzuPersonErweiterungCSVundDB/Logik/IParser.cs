using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKzuPersonErweiterungCSVundDB
{
    internal interface IParser
    {
        public List<Person> LoadPersonenListe();

        public void NeuePersonAnlegen(Person t_person);

        public void UpdatePerson(Person t_person);

        public void DeletePerson(Person t_person);

        public void ListeSpeichern(List<Person> t_liste);
    }
}
