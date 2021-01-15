using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Structure.Graph
{
    /// <summary>
    /// Граф
    /// </summary>
    public class Graph
    {/// <summary>
    /// Список вершин графа
    /// </summary>
        public List<GraphVertex> Vertices { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        public Graph()
        {
            Vertices = new List<GraphVertex>();
        }
        /// <summary>
        /// Добавить вершину
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        public void AddVertex(string vertexName)
        {
            Vertices.Add(new GraphVertex(vertexName));
        }
        /// <summary>
        /// Поиск вершины
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        /// <returns>Найденная вершина</returns>
        public GraphVertex FindVertex(string vertexName)
        {
            foreach (var vert in Vertices)
            {
                if (vert.Name.Equals(vert))
                {
                    return vert;
                }
            }
            return null;
        }
        /// <summary>
        /// Дабавление ребра
        /// </summary>
        /// <param name="firstName">Имя первой вершины</param>
        /// <param name="secondName">Имя второй вершины</param>
        /// <param name="weight">Вес</param>
        public void AddEdge(string firstName, string secondName, int weight)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2!=null&&v1!=null)
            {
                v1.AddEdge(new GraphEdge(v2,weight));
                v2.AddEdge(new GraphEdge(v1, weight));
            }
        }
    }
}
