using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
            int number = random.Next(1, 100);
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
            int number = random.Next(10, 50);

            for(int i = 0; i < number; i++)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(5);
                stopWatch.Stop();
                AddNumbersToList();
            }
        }

        public void DisplayList()
        {
            Console.WriteLine("The list of numbers to choose from is between 1 to 100.");
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i + "  ");
            //}
            Console.ReadLine();
        }

        public void ChooseANumber()
        {
            int num = 0;

            try
            {
                Console.WriteLine("Please choose a number from the list above.");
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
                ChooseANumber();
            }

            SearchTree(num, rootNode);
        }

        public void SearchTree(int number, Node node)
        {
            if(number == node.Number)
            {
                Console.WriteLine("We found your number!");
                Console.ReadLine();
            }
            else if(number > node.Number)
            {
                if (node.RightChild == null)
                {
                    Console.WriteLine("That was it, your number is not in the tree.");
                    Console.ReadLine();
                }
                else
                {
                    SearchTree(number, node.RightChild);
                }
            }
            else if(number < node.Number)
            {
                if(node.LeftChild == null)
                {
                    Console.WriteLine("That was it, your number is not in the tree.");
                    Console.ReadLine();
                }
                else
                {
                    SearchTree(number, node.LeftChild);
                }
            }
        }

        public void NodeTreeRoot()
        {
            Root();
            Begin();
        }

        public void Begin()
        {
            for(int i = 1; i < numbers.Count; i++)
            {
                AddChildren(numbers[i], rootNode);
            }
        }

        public void Root()
        {
            if(rootNode == null)
            {
                rootNode = new Node(numbers[0]);
            }
        }

        public void AddChildren(int number, Node rootNode)
        {
            if(number > rootNode.Number)
            {
                if(rootNode.RightChild == null)
                {
                    rootNode.RightChild = new Node(number);
                }
                else if(rootNode.RightChild != null)
                {
                    AddChildren(number, rootNode.RightChild);
                }
            }
            else if(number < rootNode.Number)
            {
                if(rootNode.LeftChild == null)
                {
                    rootNode.LeftChild = new Node(number);
                }
                else if (rootNode.LeftChild != null)
                {
                    AddChildren(number, rootNode.LeftChild);
                }
            }
        }

        public void Start()
        {
            NumberOfAdds();
            DisplayList();
            NodeTreeRoot();
            ChooseANumber();
        }
    }
}