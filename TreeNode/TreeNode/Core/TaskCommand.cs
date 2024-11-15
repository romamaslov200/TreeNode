using RomanLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TreeNode.Core
{
    public class TaskCommand
    {
        static Proverka proverka = new Proverka(); 
        public void add()
        {
            ClassTreeNode child = new ClassTreeNode(proverka.Type<int>(""));
            Program.root.Children.Add(child);
        }

        public void remuve()
        {
            //ClassTreeNode child = new ClassTreeNode(proverka.Type<int>(""));
            try
            {
                Program.root.Children.RemoveAt(proverka.Type<int>("Введите индекс для удаления ==> "));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void show()
        {
            //Console.Write("Введите узел которы хотите поситить");
            //ClassTreeNode child = new ClassTreeNode(proverka.Type<int>(""));
            PreOrderTraversal(Program.root);
        }

        public void showI()
        {
            try
            {
                Console.WriteLine(Program.root.Children.ElementAt(proverka.Type<int>("Введите индекс ==> ")).Value);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void PreOrderTraversal(ClassTreeNode node)
        {
            Console.WriteLine(node.Value);
            foreach (var item in node.Children)
            {
                PreOrderTraversal(item);
            }
        }

        public void showToName()
        {
            try
            {
                int s = proverka.Type<int>("Введите индекс ==> ");
                for(int i = 0; i < Program.root.Children.Count; i++)
                {
                    if (Program.root.Children[i].Value == s)
                    {
                        Console.WriteLine(Program.root.Children.First().Value);
                        return;
                    }
                        
                    Console.WriteLine("Нечего не найдено");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
