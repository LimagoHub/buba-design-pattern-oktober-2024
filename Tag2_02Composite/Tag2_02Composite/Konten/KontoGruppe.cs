using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tag2_02Composite.Konten.Visitors;

namespace Tag2_02Composite.Baum
{
    internal class KontoGruppe: AbstractKontoNode
    {
        private readonly IList<AbstractKontoNode> _children = new List<AbstractKontoNode> ();
        public KontoGruppe(string label) : base(label)
        {
        }
        public override IList<AbstractKontoNode> Children => _children.AsReadOnly();
        public override void accept(IKontenVisitor visitor)
        {
            visitor.visit(this);
        }

        public void AddChild(AbstractKontoNode child)
        {
            child.Parent = this;
            _children.Add(child);
        }

        public void RemoveChild(AbstractKontoNode child)
        {
            child.Parent = null;
            _children.Remove(child);
        }
    }
}
