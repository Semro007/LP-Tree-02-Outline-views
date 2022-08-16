using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nary_node1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test NaryNode class
            NaryNode<String> testTree = new NaryNode<String>("Root");
            NaryNode<String> nodeA = new NaryNode<String>("A");
            NaryNode<String> nodeB = new NaryNode<String>("B");
            NaryNode<String> nodeC = new NaryNode<String>("C");
            NaryNode<String> nodeD = new NaryNode<String>("D");
            NaryNode<String> nodeE = new NaryNode<String>("E");
            NaryNode<String> nodeF = new NaryNode<String>("F");
            NaryNode<String> nodeG = new NaryNode<String>("G");
            NaryNode<String> nodeH = new NaryNode<String>("H");
            NaryNode<String> nodeI = new NaryNode<String>("I");

            testTree.AddChild(nodeA);
            testTree.AddChild(nodeB);
            testTree.AddChild(nodeC);
            nodeA.AddChild(nodeD);
            nodeA.AddChild(nodeE);
            nodeC.AddChild(nodeF);
            nodeD.AddChild(nodeG);
            nodeF.AddChild(nodeH);
            nodeF.AddChild(nodeI);

            Console.WriteLine(testTree);

        }
    }
}