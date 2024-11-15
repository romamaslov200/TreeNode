using RomanLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeNode.Core;

namespace TreeNode
{
    internal class Program
    {
        static Proverka proverka = new Proverka();
        public static ClassTreeNode root = new ClassTreeNode(0);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Добавить\n2. Удалить\n3. Посмотреть все узлы\n4. Вывод по индексу\n5. Вывод по значению");
                
                ClassSwich.Vibor(proverka.Type<int>("Выберете ==> "));
                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
