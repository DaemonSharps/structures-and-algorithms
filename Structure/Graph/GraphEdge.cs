using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Structure.Graph
{/// <summary>
/// Ребро графа
/// </summary>
    public class GraphEdge
    {   /// <summary>
        /// Вес ребра
        /// </summary>
        public Int32 EdgeWeight { get; }
        /// <summary>
        /// Связанная вершина
        /// </summary>
        public GraphVertex ConnectedVertex { get; }

        /// <summary>
        /// Ребро графа
        /// </summary>
        /// <param name="connectedVertex">Связанная вершина</param>
        /// <param name="weight">Вес</param>
        public GraphEdge(GraphVertex connectedVertex, int weight)
        {
            ConnectedVertex = connectedVertex;
            EdgeWeight = weight;
        }
    }
}
