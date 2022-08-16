using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binary_node1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test NaryNode class
            BinaryNode<String> testTree = new BinaryNode<String>("Root");
            BinaryNode<String> nodeA = new BinaryNode<String>("A");
            BinaryNode<String> nodeB = new BinaryNode<String>("B");
            BinaryNode<String> nodeC = new BinaryNode<String>("C");
            BinaryNode<String> nodeD = new BinaryNode<String>("D");
            BinaryNode<String> nodeE = new BinaryNode<String>("E");
            BinaryNode<String> nodeF = new BinaryNode<String>("F");

            testTree.AddLeft(nodeA);
            testTree.AddRight(nodeB);
            nodeA.AddLeft(nodeC);
            nodeA.AddRight(nodeD);
            nodeB.AddRight(nodeE);
            nodeE.AddLeft(nodeF);

            Console.WriteLine(testTree);
        }
    }
}