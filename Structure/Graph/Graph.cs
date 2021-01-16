using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

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
        public void AddVertex(string vertexName,params string[] par)
        {
            Vertices.Add(new GraphVertex(vertexName));
            if (par!=null)
            {
                for (int i = 0; i < par.Length; i++)
                {
                    Vertices.Add(new GraphVertex(par[i]));
                }
            }
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
                if (vert.Name.Equals(vertexName))
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
            if (v1==null||v2==null)
            {
                throw new Exception($"Вершина не найдена в списке вершин: {(v1==null?firstName:secondName)}");
            }
            if (v2!=null&&v1!=null)
            {
                v1.AddEdge(new GraphEdge(v2,weight));
                v2.AddEdge(new GraphEdge(v1, weight));
            }
        }
    }
}
