using structures_and_algorithms.Structure.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Search.Dikstra
{
    public static class DikstraHelper
    {
        public static Graph CreateGraph()
        {
            Graph graph = new Graph();
            graph.AddVertex("A","B","C","E","D","F","L","G","T","O");
            graph.AddEdge("A","B",12314);
            graph.AddEdge("A","G",1273);
            graph.AddEdge("B","F",785);
            graph.AddEdge("B","C",7374);
            graph.AddEdge("C","D",420);
            graph.AddEdge("C","E",92548);
            graph.AddEdge("C","G",977893);
            graph.AddEdge("G","L",850);
            graph.AddEdge("L","F",947);
            graph.AddEdge("L","T",656);
            graph.AddEdge("T","O",98364);
            graph.AddEdge("O","F",7672);
            graph.AddEdge("O","D",6581);
            graph.AddEdge("F","E",72915);
            return graph;
        }
    }
}
