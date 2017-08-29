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

            CheckList(num);
        }

        public void CheckList(int number)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if(number == numbers[i])
                {
                    Console.WriteLine("That number is in there.");
                    SearchTree(number);
                }
                else if(number != numbers[Count - 1])
                {
                    Console.WriteLine("That number is not in the list.");
                    ChooseANumber();
                }
            }
        }

        public void SearchTree(int number)
        {

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
                    rootNode.RightChild.Number = number;
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
                    rootNode.LeftChild.Number = number;
                }
                else if (rootNode.LeftChild != null)
                {
                    AddChildren(number, rootNode.LeftChild);
                }
            }
        }
    }
}