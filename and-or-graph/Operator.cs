using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_or_graph
{
    class Operator
    {
        private Node from;
        private LinkedList<Node> branches;
        private int  cost;

        public Operator(Node from, LinkedList<Node> branches, int cost)
        {
            this.cost = cost;
            this.from = from;
            if (branches != null)
                this.branches = branches;
            else
                this.branches = new LinkedList<Node>();

            this.from.AddOperator(this);
        }

        public void AddBranch(Node branch)
        {
            this.branches.AddFirst(branch);
        }

        public int CalculateHeuristicCost()
        {
            int cost = 0;
            foreach (Node branch in branches)
            {
                cost += branch.CalculateEstimatedCost();
            }
            return cost;
        }

        public int Cost { get => cost; set => cost = value; }
        internal Node From { get => from; set => from = value; }
        internal LinkedList<Node> Branches { get => branches; set => branches = value; }
    }
}
