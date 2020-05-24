using System;
using System.Collections.Generic;

namespace DiscreteMathematicsProj
{
    class Node
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public List<Node> neighbor;

        static public List<string> KeyStore;

        public Node(string key,string name)
        {
            Key = key;
            Name = name;
            KeyStore.Add(Key.ToUpper());
        }
        public Node(string key,double x,double y,string name)
        {
            Key = key;
            X = x;
            Y = y;
            Name = name;
            KeyStore.Add(Key.ToUpper());
        }

        static public bool validcheck(string key)
        {
            key = key.ToUpper();
            for(int i = 0; i < KeyStore.Count; ++i)
            {
                if (key == KeyStore[i])
                {
                    return true;
                }
            }

            return false;
        }


    }

    class Edge
    {
        public double Price { get; set; }
        public Edge(string SNode,string ENode)
        {

        }
    }

    class Graph
    {
        

        
    }

    class Program
    {
        static public List<Node> nodes;
        static public List<Edge> edges;

        static void header()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================================================");
            Console.WriteLine("       Discrete Mathematics Project Developed by Hessam Hosseini 98521144");
            Console.WriteLine("================================================================================");
            Console.ResetColor();
        }
        static void menu()
        {
            again:
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("   1.Count of Component    2.Atleast Fly   3.Cheper Fly(Dijkstra)   4.Cheper Fly");
                Console.Write("Choose one of sections :");
                Console.ForegroundColor = ConsoleColor.Green;
                int order = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (order)
                {
                    case 1:
                        Console.Clear();
                        Sec1();
                        break;

                    case 2:
                        Console.Clear();
                        Sec2();
                        break;

                    case 3:
                        Console.Clear();
                        Sec3();
                        break;

                    case 4:
                        Console.Clear();
                        Sec4();
                        break;

                    default:
                        throw new Exception();
                        
                }

            }
            catch
            {
                Console.Clear();
                header();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter the Number of Sections in the Menu .");
                Console.ResetColor();
                goto again;
            }
        }

        static void Sec1()
        {
            again3:
            try
            {
                header();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter the numbers :");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                string[] sep = input.Split(' ');
                int i = int.Parse(sep[0]);
                int j = int.Parse(sep[1]);

                nodes = new List<Node>();
                nodes.Capacity = i;

                edges = new List<Edge>();
                edges.Capacity = j;

                string[] inputsep;

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int k = 0; k < i; ++k)
                {
                again2:
                    try
                    {
                        Console.WriteLine("Enter the Airport{0} information :", k + 1);

                        Console.ForegroundColor = ConsoleColor.Green;
                        inputsep = (Console.ReadLine()).Split(' ');

                        string key = inputsep[0];
                        string name = inputsep[1] + " " + inputsep[2];


                        nodes.Add(new Node(key, name));

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Type !!!");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        goto again2;
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for(int k = 0; k < j; ++k)
                {
                again4:
                    try
                    {
                        Console.WriteLine("Enter the Edge{0} :", k + 1);

                        Console.ForegroundColor = ConsoleColor.Green;

                        inputsep = (Console.ReadLine()).Split(' ');

                        string firstkey = inputsep[0];
                        string endkey = inputsep[1];

                        if(Node.validcheck(firstkey) && Node.validcheck(endkey))
                        {
                            edges.Add(new Edge(firstkey, endkey));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Keys !!!");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            goto again4;
                        }


                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Type !!!");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        goto again4;
                    }
                }
            
                
            
            
            
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Type !!!");
                goto again3;
            }
        }

        static void Sec2()
        {
            header();
            Console.WriteLine("2");
        }

        static void Sec3()
        {
            header();
            Console.WriteLine("3");
        }

        static void Sec4()
        {
            header();
            Console.WriteLine("4");
        }

        static void Main()
        {
            header();
            menu();
        }
    }
}
