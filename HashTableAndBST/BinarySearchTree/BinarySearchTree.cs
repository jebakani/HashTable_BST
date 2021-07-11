using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //create the class for storing the value in the node 
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
    //create the binary search tree class that extends IComparable for comparision
    class BinarySearchTree<T> where T:IComparable
    {
        public TreeNode<T> root;
        int count = 0;
        //create the add node method
        public void AddNode(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>(value);
            //if the new node is the first node then point root tothe current node
            if(root==null)
            {
                root = newNode;
            }
            //else check for greater or lesser condition
            else
            {
                TreeNode<T> parent = root;
                TreeNode<T> current = root;
                //continue the below process till the target position  is achieved
                while(true)
                {
                    parent = current;
                    //if the current node value is greater than new node then iterate to left till null
                    if(current.value.CompareTo(value)>=0)
                    {
                        current = current.Left;
                        if(current==null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //if the current node value is less than new node then iterate to right till null
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

        public int SizeOf(TreeNode<T> parent)
        {
            //if the root is null then tree is empty
            if(parent == null )
            {
                return 0;
            }
            //else find size of left sub tree and size of right sub tree then add together with one root node
            else
            {
                return (SizeOf(parent.Left) + 1 + SizeOf(parent.Right));
            }
        }
    }
}
