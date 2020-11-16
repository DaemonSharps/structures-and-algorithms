using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms
{
    class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next {get;set;}
    }
}
