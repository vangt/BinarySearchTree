using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree.Classes
{
    public class BinaryTree
    {
        public Node rootNode;
        public List<int> numbers = new List<int>();
        private int count;
        
        public BinaryTree()
        {
            rootNode = null;
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                this.count = value;
            }
        }

        public void GetCount()
        {
            Count = numbers.Count();
        }

        public int GetNumbers()
        {
            Random random = new Random();
            int number = random.Next(10, 100);
            return number;
        }

        public void AddNumbersToList()
        {
            int addedNumber = GetNumbers();
            numbers.Add(addedNumber);
        }

        public void NumberOfAdds()
        {
            Random random = new Random();
            int number = random.Next(0, 50);

            for(int i = 0; i < number; i++)
            {
                AddNumbersToList();
            }
        }

        public void DisplayList()
        {
            Console.WriteLine("The list of numbers to choose from:");
            foreach(int i in numbers)
            {
                Console.WriteLine(i + "  ");
            }
            Console.ReadLine();
        }

        public void NodeTreeRoot(int number)
        {
            Node newNode = new Node();
            newNode.Number = number;
            newNode.Number = rootNode.Number;
        }

        public void Begin()
        {
            for(int i = 1; i < numbers.Count; i++)
            {
                AddChildren(numbers[i]);
            }
        }

        public void AddChildren(int number)
        {
            Node node = new Node();
            Node temp = new Node();

            node = rootNode;
            while (node.LeftChild != null || node.RightChild != null)
            {
                if (temp.Number > node.Number && node.RightChild != null)
                {
                    node.RightChild = node;
                }
                else if (temp.Number < node.Number && node.LeftChild != null) 
                {
                    node.LeftChild = node;
                }
                else if(temp.Number > node.Number && node.RightChild == null)
                {
                    break;
                }
                else if(temp.Number < node.Number && node.LeftChild == null)
                {
                    break;
                }

            }
            node.Number = temp.Number;
        }
    }
}
