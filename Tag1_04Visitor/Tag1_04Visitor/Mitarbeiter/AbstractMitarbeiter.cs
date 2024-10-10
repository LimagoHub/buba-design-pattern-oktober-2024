using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag1_04Visitor.Mitarbeiter.Visitors;

namespace Tag1_04Visitor.Mitarbeiter
{
    internal abstract class AbstractMitarbeiter
    {
        public string Name { get; set; }
        protected AbstractMitarbeiter(string name) {
            Name = name;
        }

        public override string ToString()
        {
            return GetType().Name + ": name=" + Name;
        }

        public abstract void accept(MitarbeiterVisitor visitor);
    }
}
