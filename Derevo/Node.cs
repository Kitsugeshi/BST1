using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Node<T> where T : IComparable<T>
    { 
        public T Data { get; set; }
        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }

        public Node(T data) 
        {
            Data = data;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;   
                }
                else Left.Add(data);   
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else Right.Add(data);
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
