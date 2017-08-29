using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Classes
{
    public class Node
    {
        private Node leftChild;
        private Node rightChild;
        private int number;

        public Node(int number)
        {
            this.number = number;
            this.leftChild = null;
            this.rightChild = null;
        }

        public Node LeftChild
        {
            get
            {
                return leftChild;
            }
            set
            {
                this.leftChild = value;
            }
        }

        public Node RightChild
        {
            get
            {
                return rightChild;
            }
            set
            {
                this.rightChild = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = value;
            }
        }
    }
}
