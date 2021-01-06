using System;
using structures_and_algorithms.Structure;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public class TreeSort:ISort
    {
        public Int32[] Sort(Int32[] arr)
        {
            var treenode = new TreeNode(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                treenode.Insert(new TreeNode(arr[i]));
            }
            arr = treenode.Transform();
            return arr;
        }
    }
}
