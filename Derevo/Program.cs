using System;

namespace BST
{
    class Programm
    {
        static void Main()
        {
            Tree<string> tree = new Tree<string>();

            tree.Add("собака");
            tree.Add("як");
            tree.Add("кит");
            tree.Add("слон");
            tree.Add("кот");
            tree.Add("белка");

            Console.WriteLine("Обход в ширину: ");
            tree.BreadthFirstSearch();
            Console.WriteLine("\n");

            Console.WriteLine("Обход в глубину: ");
            tree.DepthFirstSearch();
            Console.WriteLine("\n");

            Console.WriteLine("Прямой обход: ");
            foreach (var item in tree.PreorderLog())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Постфиксный обход: ");
            foreach (var item in tree.PostorderLog())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Инфиксный обход: ");
            foreach (var item in tree.InorderLog())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}





