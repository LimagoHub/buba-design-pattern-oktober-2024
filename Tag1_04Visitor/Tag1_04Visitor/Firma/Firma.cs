using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag1_04Visitor.Mitarbeiter;
using Tag1_04Visitor.Mitarbeiter.Visitors;

namespace Tag1_04Visitor.Firma
{
    internal class Firma
    {
        private IList<AbstractMitarbeiter> mitarbeiters;

        /*public IList<AbstractMitarbeiter> Mitarbeiters { 
            get {
                return new ReadOnlyCollection<AbstractMitarbeiter>(mitarbeiters);
            } 
        }*/

        public Firma()
        {
            mitarbeiters = new List<AbstractMitarbeiter>();
        }

        public void AddMitarbeiter(AbstractMitarbeiter mitarbeiter)
        {
            // Pruefungen
            mitarbeiters.Add(mitarbeiter);
        }

        public void RemoveMitarbeiter(AbstractMitarbeiter mitarbeiter)
        {
            // Pruefungen
            mitarbeiters.Remove(mitarbeiter);
        }

        public void Print()
        {
            foreach (var mitarbeiter in mitarbeiters)
            {
                Console.WriteLine(mitarbeiter);
            }
        }

        public void iterate(MitarbeiterVisitor visitor)
        {
            foreach (var abstractMitarbeiter in mitarbeiters)
            {
                //visitor.visit(abstractMitarbeiter);
                abstractMitarbeiter.accept(visitor);
            }
        }
    }
}
