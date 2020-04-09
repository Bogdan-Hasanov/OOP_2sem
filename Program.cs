using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2sem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            Console.WriteLine("Завдання 1");
            BinaryTree<Student> binaryTree = new BinaryTree<Student>();
            binaryTree.Notify += (message, node) =>  Console.WriteLine(message+node);
            Console.WriteLine("\n\nДодаємо студентів до бінарного дерева\n\n");
            binaryTree.Add(new Student(5,"Yura", "Test 1", "date 1"));
            binaryTree.Add(new Student(12,"Vova", "Test 1", "date 1"));
            binaryTree.Add(new Student(11,"Andrey", "Test 1", "date 1"));
            Console.WriteLine("Шукаємо студента з оцінкою 5");
            Console.WriteLine(binaryTree.FindNode(new Student(mark:5)));
            Console.WriteLine("Вивід елементів дерева по порядку");
            BinaryTree<Student>.InOrderTraversal(binaryTree.RootNode);
            Console.WriteLine("Вивід дерева");
            binaryTree.PrintTree();

            Console.ReadLine();
            //Завдання 2
            Console.WriteLine("Завдання 2");
            CustomDictionary customDictionary = new CustomDictionary();
            customDictionary[-1] = new Student();
            customDictionary[-2] = new BinaryTree<Student>();
      
            foreach (object var in customDictionary)
            {
                Console.WriteLine(var.ToString());
            }
            Console.ReadLine();
        }
    }
}
