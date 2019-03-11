// Created by Ivan Martsilenko K-24
// Lab 1 Sem 2
// main part

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm
{
    class Program
    {
        private static Graph Graph = new Graph();
        private static Graph GraphOneWay = new Graph();
        private static DataLoading Load = new DataLoading();
              
        private static BreadthFirstSearchAlgorithm BFS = new BreadthFirstSearchAlgorithm(Graph);
        private static DepthFirstSearchAlgorithm DFS = new DepthFirstSearchAlgorithm(Graph);
        private static KruscalAlgorithm Kruscal = new KruscalAlgorithm(Graph);
        private static PrimaAlgorithm Prima = new PrimaAlgorithm(Graph);
        private static BellmanFordAlgorithm BellmanFord = new BellmanFordAlgorithm(Graph);
        private static DijkstraAlgorithm Dijkstra = new DijkstraAlgorithm(Graph);
        private static Floyd_WarshallAlgorithm Floyd_Warshall = new Floyd_WarshallAlgorithm(Graph);
        private static JohnsonAlgorithm Johnson = new JohnsonAlgorithm(Graph);
        private static FordFulkersonAlgorithm FordFulkerson = new FordFulkersonAlgorithm(Graph);
        private static A_Star A_Star = new A_Star(Graph);

        static void Main(string[] args)
        { 
             
                Console.ReadKey();
        }
    }

}
