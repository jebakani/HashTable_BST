using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode<T>
    {
        public T value;
        public TreeNode<T> Left;
        public TreeNode<T> Right;
        public TreeNode(T value)
        {
            this.value = value;
            this.Left = null;
            this.Right = null;
        }
    }
    class BinarySearchTree<T> where T:IComparable
    {
        public TreeNode<T> root;

        public void AddNode(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>(value);
            if(root==null)
            {
                root = newNode;
            }
            else
            {
                TreeNode<T> parent = root;
                TreeNode<T> current = root;
                while(true)
                {
                    parent = current;
                    if(current.value.CompareTo(value)>=0)
                    {
                        current = current.Left;
                        if(current==null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public void display(TreeNode<T> parent)
        {
            if (parent != null)
            {
                display(parent.Left);
                Console.WriteLine("The node :{0}", parent.value);
                display(parent.Right);
            }
        }
    }
}
