using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_or_graph
{
    class Node
    {
        private bool terminal;
        private int id;
        private int heuristic;
        private int cost;
        private LinkedList<Operator> operators;

        public Node (int id, int heuristic, int cost, bool terminal, LinkedList<Operator> operators = null)
        {
            this.terminal = terminal;
            this.id = id;
            this.heuristic = heuristic;
            this.cost = cost;
            if (operators != null)
                this.operators = operators;
            else
                this.operators = new LinkedList<Operator>();
        }

        public void AddOperator(Operator item)
        {
            this.operators.AddFirst(item);
        }

        public int CalculateEstimatedCost()
        {
            int cost = this.cost;
            foreach (Operator op in this.operators)
            {
                cost += op.Cost + op.CalculateHeuristicCost();
            }
            return cost;
        }


        public int Id { get => id; set => id = value; }
        public int Heuristic { get => heuristic; set => heuristic = value; }
        public int Cost { get => cost; set => cost = value; }
        public LinkedList<Operator> Operators { get => operators; set => operators = value; }
        public bool IsTerminal { get => terminal; set => terminal = value; }
    }
}
