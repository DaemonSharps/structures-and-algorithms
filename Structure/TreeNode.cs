using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Structure
{
   public class TreeNode
    { public TreeNode(Int32 data)
        {
            Data = data;
        }
        Int32 Data { get; set; }
        TreeNode Right { get; set; }
        TreeNode Left { get; set; }
        public void Insert(TreeNode node)
        {
            if (node.Data<Data)
            {
                if (Left==null)
                {
                    Left = node;
                }
                else
                {
                    Left.Insert(node);
                }
            }
            else
            {
                if (Right==null)
                {
                    Right = node;
                }
                else
                {
                    Right.Insert(node);
                }
            }
        }
        public Int32[] Transform(List<Int32> elems=null)
        {
            if (elems==null)
            {
                elems = new List<Int32>();
            }
            if (Left!=null)
            {
                Left.Transform(elems);
            }
            elems.Add(Data);
            if (Right!=null)
            {
                Right.Transform(elems);
            }
            return elems.ToArray();
        }

    }
}
