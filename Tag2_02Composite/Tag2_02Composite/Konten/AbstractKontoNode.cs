﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Tag2_02Composite.Konten.Visitors;

namespace Tag2_02Composite.Baum
{
    internal abstract class AbstractKontoNode: IEnumerable<AbstractKontoNode>
    {

        
        public string Label { get; set; }
        public AbstractKontoNode Parent { get; set; }

        public virtual IList<AbstractKontoNode> Children => new List<AbstractKontoNode>().AsReadOnly();

        public AbstractKontoNode(string label)
        {
            Label = label;
            Parent = null;
        }


        public IEnumerator<AbstractKontoNode> GetEnumerator()
        {

            IList<AbstractKontoNode> liste = new List<AbstractKontoNode> ();
            FillListForEnumerator(liste);
            return liste.GetEnumerator();
        }

        private void FillListForEnumerator(IList<AbstractKontoNode> liste)
        {
            liste.Add(this);
            foreach (var child in Children)
            {
                child.FillListForEnumerator(liste);
                
            }
        }

        public override string ToString() => $"{GetType().Name}: {nameof(Label)}: {Label}";
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Print()
        {
            foreach (var node in this)
            {
                Console.WriteLine(node);
              
            }
        }

        public abstract void accept(IKontenVisitor visitor);

        public void iterate(IKontenVisitor visitor)
        {
            visitor.init();
            foreach (var node in this)
            {
                node.accept(visitor);
            }
            visitor.dispose();
        }
    }
}
