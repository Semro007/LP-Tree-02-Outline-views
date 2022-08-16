using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nary_node1
{
    internal class NaryNode<T>
    {
        internal T Value { get; set; }
        internal List<NaryNode<T>>? Children { get; set; }

        // Constructor
        internal NaryNode(T pValue)
        {
            Value = pValue;
            Children = new List<NaryNode<T>>();
        }

        internal void AddChild(NaryNode<T> pNewNode)
        {
            Children.Add(pNewNode);
        }

        internal String ToString(String spaces)
        {
            String retValue = $"{spaces}{Value}:\n";
            foreach (NaryNode<T> child in Children)
                retValue += child.ToString(spaces+"  ");
            return retValue;
        }

        public override String ToString()
        {
            return this.ToString("");
        }

    }
}