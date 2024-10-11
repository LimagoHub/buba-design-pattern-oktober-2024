using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2_02Composite.Baum
{
    internal class AbstractNode
    {
        public string Label { get; set; }
        public AbstractNode Parent { get; set; }

        public virtual IList<AbstractNode> Children => new List<AbstractNode>().AsReadOnly();

        public AbstractNode(string label)
        {
            Label = label;
            Parent = null;
        }

     

        public override string ToString() => $"{GetType().Name}: {nameof(Label)}: {Label}";
    }
}
