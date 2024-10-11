using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_02Composite.Baum
{
    internal class Node: AbstractNode
    {
        private readonly IList<AbstractNode> _children = new List<AbstractNode> ();
        public Node(string label) : base(label)
        {
        }
        public override IList<AbstractNode> Children => _children.AsReadOnly();

        public void AddChild(AbstractNode child)
        {
            child.Parent = this;
            _children.Add(child);
        }

        public void RemoveChild(AbstractNode child)
        {
            child.Parent = null;
            _children.Remove(child);
        }
    }
}
