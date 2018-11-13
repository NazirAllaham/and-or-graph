using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_or_graph
{
    class AndOrGraph
    {
        Queue<Node> q;
        LinkedList<Node> nodes;
        LinkedList<Operator> operators;

        public AndOrGraph()
        {
            this.q = new Queue<Node>();
            this.nodes = new LinkedList<Node>();
            this.operators = new LinkedList<Operator>();
        }

        public void AddNode(Node node)
        {
            this.nodes.AddFirst(node);
        }
        
        public void AddOperator(int from, int to, int cost)
        {
            Operator op = new Operator(nodes.ElementAt(from), null, cost);
            op.AddBranch(nodes.ElementAt(to));
            this.operators.AddFirst(op);
        }

        public void Traverse(int root)
        {
            q.Enqueue(nodes.ElementAt(root));

            while(q.Count > 0)
            {
                Node top = q.Dequeue();

                if(top.IsTerminal)
                {
                    Console.WriteLine(top.Id);
                    Console.WriteLine("Yes, We get access to terminal node");
                    return;
                }

                foreach (Operator op in top.Operators)
                {
                    foreach (Node node in op.Branches)
                    {
                        q.Enqueue(node);
                    }
                }
            }
        }
    }
}
