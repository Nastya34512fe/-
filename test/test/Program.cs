using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q = 0;
            Console.WriteLine("What data type is boolean? \n1 float \n2 bool \n3 char");
            string ot1 = Console.ReadLine();
            if (ot1 == "2")
            { q++; }
            Console.WriteLine("What formatted output option has percentage format? \n1 P \n2 G \n3 N");
            string ot2 = Console.ReadLine();
            if (ot2 == "1")
            { q++; }
            Console.WriteLine("What does exponentiation look like in a C# mathematical function? \n1 Math.Round \n2 Math.Exp \n3 Math.Pow \n4 Math.Ceiling");
            string ot3 = Console.ReadLine();
            if (ot3 == "3")
            { q++; }
            Console.WriteLine("What data type does 'A'? \n1 string \n2 char");
            string ot4 = Console.ReadLine();
            if (ot4 == "2")
            { q++; }
            Console.WriteLine("How is the dimension of an array indicated? \n1 int \n2 long \n3 name \n4 []");
            string ot5 = Console.ReadLine();
            if (ot5 == "4")
            { q++; }
            Console.WriteLine("What basic types of C# language have 16 bit memory? \n1 short \n2 double \n3 decimal \n4 char \n5 ushort");
            string ot6 = Console.ReadLine();
            if (ot6 == "1, 4, 5")
            { q++; }
            Console.WriteLine("What does increment and decrement look like? \n1 ++ \n2 == \n3 != \n4 --");
            string ot7 = Console.ReadLine();
            if (ot7 == "1, 4")
            { q++; }
            Console.WriteLine("What does multiplication look like in binary operators? \n1 a*=b \n2 a-b \n3 a/b \n4 a*b \n5 a%b");
            string ot8 = Console.ReadLine();
            if (ot8 == "1, 4")
            { q++; }
            Console.WriteLine("What are the basic types of C# language that represent a non-negative integer? \n1 sbyte \n2 byte \n3 ulong \n4 float \n5 int");
            string ot9 = Console.ReadLine();
            if (ot8 == "2, 3")
            { q++; }
            Console.WriteLine("An array is a collection of...data. \n1 multi-type \n2 of the same type");
            string ot10 = Console.ReadLine();
            if (ot10 == "1")
            { q++; }
            Console.WriteLine("Logical data type bool has values true/.... \n1 name \n2 false");
            string ot11 = Console.ReadLine();
            if (ot11 == "2")
            { q++; }
            Console.WriteLine("What basic types of C# language are dascribed as integer? \n1 ulong \n2 short \n3 int");
            string ot12 = Console.ReadLine();
            if (ot12 == "2, 3")
            { q++; }
            Console.WriteLine("What is the structure of the basic float data type? \n1 Decimal \n2 Boolean \n3 Single");
            string ot13 = Console.ReadLine();
            if (ot13 == "2, 3")
            { q++; }
            Console.WriteLine("Features of the do...while postcondition cycle. \n1 can be executed 0 times \n2 there is no specific step \n3 is performed at least once");
            string ot14 = Console.ReadLine();
            if(ot14 == "2, 3")
            { q++; }
            Console.WriteLine("What does break do? \n1 skips the current step of the loop \n2 completing the cycle entirely");
            string ot15 = Console.ReadLine();
            if (ot15 == "2")
            { q++; }
            Console.WriteLine(q);
            }

        }
    }

