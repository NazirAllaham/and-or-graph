using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_or_graph
{
    class Program
    {
        static void Main(string[] args)
        {
            AndOrGraph mGraph = new AndOrGraph();
            mGraph.AddNode(new Node(0, 10, 10, false, null));
            mGraph.AddNode(new Node(1, 10, 10, true, null));
            mGraph.AddNode(new Node(2, 10, 10, false, null));
            mGraph.AddNode(new Node(3, 10, 10, true, null));

            mGraph.AddOperator(0, 1, 8);
            mGraph.AddOperator(0, 2, 8);
            mGraph.AddOperator(2, 3, 8);

            mGraph.Traverse(0);

            Console.ReadKey();
        }
    }
}
