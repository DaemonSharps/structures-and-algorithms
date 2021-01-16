using System;
using System.Collections.Generic;
using System.Text;
using structures_and_algorithms.Structure.Graph;

namespace structures_and_algorithms.Algorithms.Search.Dikstra
{
    /// <summary>
    /// Алгоритм Дейкстры
    /// </summary>
     public class DiikstraAlgoritm
    {
        Graph graph;
        List<GraphVertexInfo> info;
        /// <summary>
        /// Алгоритм Дейкстры
        /// </summary>
        /// <param name="newGraph"></param>
        public DiikstraAlgoritm(Graph newGraph)
        {
            graph = newGraph;
        }
        /// <summary>
        /// Инициализация информации о графе
        /// </summary>
        void InitInfo()
        {
            info = new List<GraphVertexInfo>();
            foreach (var vert in graph.Vertices)
            {
                info.Add(new GraphVertexInfo(vert));
            }
        }
        /// <summary>
        /// Получение информации о вершине
        /// </summary>
        /// <param name="vert"></param>
        /// <returns></returns>
        GraphVertexInfo GetVertexInfo(GraphVertex vert)
        {
            foreach (var inf in info)
            {
                if (inf.Vertex.Equals(vert))
                {
                    return inf;
                }
            }
            return null;
        }
        /// <summary>
        /// Поиск непосещенной вершины с минимальным значением суммы
        /// </summary>
        /// <returns>Информация о вершине</returns>
        public GraphVertexInfo FindUnvisitedVertexWithMinSum()
        {
            var min = Int32.MaxValue;
            GraphVertexInfo minVretexInfo=null;
            foreach (var inf in info)
            {
                if (inf.IsUnvisited && inf.EdgesWeightSum<min)
                {
                    minVretexInfo = inf;
                    min = inf.EdgesWeightSum;
                }
            }
            return minVretexInfo;
        }
        /// <summary>
        /// Поиск кратчайшего пути по названиям вершин
        /// </summary>
        /// <param name="startName">Название стартовой вершины</param>
        /// <param name="finishName">Название финишной вершины</param>
        /// <returns></returns>
        public string FindShortestPath(string startName,string finishName)
        {
            return FindShortestPath(graph.FindVertex(startName),graph.FindVertex(finishName));
        }
        /// <summary>
        /// Поиск кратчайшего пути по вершинам
        /// </summary>
        /// <param name="startVertex">Начальная вершина</param>
        /// <param name="finishVertex">Конечная вершина</param>
        /// <returns>Путь</returns>
        public string FindShortestPath(GraphVertex startVertex,GraphVertex finishVertex)
        {
            InitInfo();
            var first = GetVertexInfo(startVertex);
            first.EdgesWeightSum = 0;
            while (true)
            {
                var current = FindUnvisitedVertexWithMinSum();
                if (current==null)
                {
                    break;
                }
                SetSumToNextVertex(current);     
            }
            return GetPath(startVertex,finishVertex);
        }
        /// <summary>
        /// Формирование пути
        /// </summary>
        /// <param name="startVertex">Начальная вершина</param>
        /// <param name="finishVertex">Конечная вершина</param>
        /// <returns>Путь</returns>
        string GetPath(GraphVertex startVertex, GraphVertex finishVertex)
        {
            var path = finishVertex.ToString();
            while (startVertex!=finishVertex)
            {
                finishVertex = GetVertexInfo(finishVertex).PreviousVertex;
                path = finishVertex.ToString()+path;
            }
            return path;
        }

        /// <summary>
        /// Вычисление сумм ребер для следующей вершины
        /// </summary>
        /// <param name="info">Информация о текущей вершине</param>
        void SetSumToNextVertex(GraphVertexInfo info)
        {
            info.IsUnvisited = false;
            foreach (var edge in info.Vertex.Edges)
            {
                var nextInfo = GetVertexInfo(edge.ConnectedVertex);
                var sum = info.EdgesWeightSum + edge.EdgeWeight;
                if (sum<nextInfo.EdgesWeightSum)
                {
                    nextInfo.EdgesWeightSum = sum;
                    nextInfo.PreviousVertex = info.Vertex;
                }
            }
        }
    }
}
