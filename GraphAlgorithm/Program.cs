// Created by Ivan Martsilenko K-24

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    public class Graph
    {


    }

    /// <summary>
    /// public class Coordinate create field with Decard coordinate system
    /// </summary>
    public class Coordinate
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinate(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }
    }

    /// <summary>
    /// class Node connected to class Coodinate and class Edge
    /// </summary>
    public class Node : ICloneable
    {
        public Coordinate Coordinate { get; private set; }
        public string Name { get; set; }

        public Node[] Incomers { get; set; }

        // need for A*, TotalPathCost = PastWayCost + HeuristicCost;
        public double HeuristicCost { get; set; }
        public double PastWayCost { get; set; }
        public double TotalPathCost { get; set; }

        public int Index { get; set; }

        public override bool Equals(object Object)
        {
            Node Node = (Node)Object;
            return this.Name.Equals(Node.Name);
        }

        // need for realization of ICloneable interface
        public object Clone()
        {
            Node Node = new Node
            {
                Coordinate = this.Coordinate,
                Incomers = this.Incomers,
                Name = this.Name,
                Index = this.Index,
            };
            return Node;
        }

        public Node()
        {
            HeuristicCost = 0.0;
            PastWayCost = 0.0;
            TotalPathCost = 0.0;
            Name = string.Empty;
            Coordinate = null;
            Incomers = null;
            Index = 0;
        }

        public Node this[int Index]
        {
            get
            {
                if (Index >= 0 && Index < Incomers.Length)
                {
                    return Incomers[Index];
                }
                return null;
            }
            set
            {
                if (Index >= 0 && Index < Incomers.Length)
                {
                    Incomers[Index] = value;
                }
            }
        }

        public Node(int NumberOfIncomers, string Name, Coordinate Coordinate)
        {
            Incomers = new Node[NumberOfIncomers + 1];

            this.Coordinate = Coordinate;

            this.Name = $"[{Name}]";

            Index = 0;
        }
        public Node(int NumberOfIncomers, string Name)
        {
            Incomers = new Node[NumberOfIncomers + 1];

            this.Name = $"[{Name}]";

            Index = 0;
        }
    }

    public class Edge : ICloneable
    {

        public string Name { get; private set; }
        public double Weight { get; set; }
        public int Index { get; set; }
        public List<Node> Ends { get; private set; }

        public Node this[int Index]
        {
            get
            {
                if (Index >= 0 && Index <= 1)
                {
                    return Ends[Index];
                }

                return null;
            }
        }
        public Edge()
        {
            Ends = new List<Node>();

            Name = string.Empty;

            Weight = 0.0;

            Index = 0;
        }
        public object Clone()
        {
            List<Node> EndsOfEdge = new List<Node>()
            {
                (Node)this.Ends[0].Clone(),

                (Node)this.Ends[1].Clone()
            };

            Edge Edge = new Edge
            {
                Weight = this.Weight,

                Name = this.Name,

                Index = this.Index,

                Ends = EndsOfEdge
            };
            return Edge;
        }
    }

}
