using System;
using System.Collections.Generic;
using System.Text;
using structures_and_algorithms.Structure.Graph;

namespace structures_and_algorithms.Algorithms.Search.Dikstra
{
    /// <summary>
    /// Информация о вершине
    /// </summary>
    public class GraphVertexInfo
    {
        /// <summary>
        /// Вершина
        /// </summary>
        public GraphVertex Vertex { get; set; }
        /// <summary>
        /// Не посещенная вершина
        /// </summary>
        public bool IsUnvisited { get; set; }
        /// <summary>
        /// Сумма весов ребер
        /// </summary>
        public Int32 EdgesWeightSum { get; set; }
        /// <summary>
        /// Предыдущая вершина
        /// </summary>
        public GraphVertex PreviousVertex { get; set; }
        /// <summary>
        /// Информация о вершине
        /// </summary>
        public GraphVertexInfo(GraphVertex vertex)
        {
            Vertex = vertex;
            IsUnvisited = true;
            EdgesWeightSum = Int32.MaxValue;
            PreviousVertex = null;
        }
    }
}
