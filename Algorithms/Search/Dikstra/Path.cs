using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Search.Dikstra
{
    /// <summary>
    /// Путь от вершины до вершны в Графе
    /// </summary>
    public class Path
    {
        /// <summary>
        /// Точки пути
        /// </summary>
        public string Points { get; set; }
        /// <summary>
        /// Вес пути
        /// </summary>
        public Int32 Weight { get; set; }
    }
}
