using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Language
{
    public  class Commander
    {
        public static void MAIN(String file)
        {
            String[] var_value = new string[1024];
            String[] var_name = new string[1024];
            bool File_Mod = false;
            bool Math_module = false;
            bool LGL_Module = false;
            int uses = 0;
            int frst = 0;
            String[] str = File.ReadAllLines(file);
            for (int i = 0; i < str.Length; i++)
            {
            Label:
                int zc = 0;
                String[] line = str[i].Split(' '); //str[i].Split(' ')
                switch (line[0])
                {
                    default:
                        Console.Write("Uncnown function,press any key to continue...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    case "writeln"://writeln[0] 5[1] +[2] 5[3]
                        String[] gr = str[i].Split('"', '"');
                        if(gr.Length > 1)
                        {
                            Console.WriteLine(gr[1]);
                            break;
                        }
                        if (line.Length >= 3)
                        {
                            Console.WriteLine(parser.NumberExpression(Convert.ToInt32(line[1]),
                                Convert.ToChar(line[2]),
                                Convert.ToInt32(line[3])));
                        }
                        int use = 0;
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if (el1 == g)
                            {
                                Console.WriteLine(var_value[use]);
                                zc++;
                                break;
                            }
                        }
                        if (zc == 0)
                        {
                            ;
                        }
                        else
                        {
                            ;
                        }
                        zc = 0;
                        break;
                    case "write":
                        gr = str[i].Split('"', '"');
                        if (gr.Length > 1)
                        {
                            Console.WriteLine(gr[1]);
                            break;
                        }
                        if (line.Length >= 3)
                        {
                            Console.Write(parser.NumberExpression(Convert.ToInt32(line[1]),
                                Convert.ToChar(line[2]),
                                Convert.ToInt32(line[3])));
                            i++;
                            goto Label;
                        }
                        int use2 = 0;
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if (el1 == g)
                            {
                                Console.Write(var_value[use2]);
                                zc++;
                                break;
                            }
                        }
                        if (zc == 0)
                        {
                            ;
                        }
                        else
                        {
                            ;
                        }
                        zc = 0;
                        break;
                    case "var"://var[0] var1[1] = [2] 5[3]
                        String[] eq = str[i].Split('=');
                        var_name[uses] = line[1];
                        var_value[uses] = eq[1];
                        uses++;
                        break;
                    case "read":
                        int use1 = 0;
                        foreach (String el in var_name)
                        {
                            String g = line[1];
                            if (el == g)
                            {
                                var_value[use1] = Console.ReadLine();
                                zc++;
                                break;
                            }
                        }
                        if (zc == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not found variable : " + line[1]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            ;
                        }
                        zc = 0;
                        break;
                    case "readKey":
                        Console.ReadKey();
                        break;
                    case "color":
                        if (line[1] == "red") Console.ForegroundColor = ConsoleColor.Red;
                        if (line[1] == "blue") Console.ForegroundColor = ConsoleColor.Blue;
                        if (line[1] == "green") Console.ForegroundColor = ConsoleColor.Green;
                        if (line[1] == "cyan") Console.ForegroundColor = ConsoleColor.Cyan;
                        if (line[1] == "magenta") Console.ForegroundColor = ConsoleColor.Magenta;
                        if (line[1] == "white") Console.ForegroundColor = ConsoleColor.White;
                        if (line[1] == "yellow") Console.ForegroundColor = ConsoleColor.Yellow;
                        if (line[1] == "gray") Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "fif"://fif[0] 5[1] >[2] 5[3]
                        int use3 = 0;
                        int l1 = 0, l2 = 0;
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if (el1 == g)
                            {
                                l1 = Convert.ToInt32(var_value[use3]);
                                zc++;
                                use3++;
                                break;
                            }
                        }
                        foreach (String el1 in var_name)
                        {
                            String g = line[3];
                            if (el1 == g)
                            {
                                l2 = Convert.ToInt32(var_value[use3]);
                                zc++;
                                use3++;
                                break;
                            }
                        }
                        bool tof;
                        if (zc == 2)
                        {
                            tof = parser.QuestionExpression(l1, line[2], Convert.ToInt32(l2));
                            Console.WriteLine(tof);
                        }
                        else//fif[0] 5[1] >[2] 5[3]
                        {
                            tof = parser.QuestionExpression(Convert.ToInt32(line[1]),
                                line[2],
                                Convert.ToInt32(line[3]));
                            Console.WriteLine(tof);
                        }
                        break;
                    case "if":
                        int use4 = 0;
                        int a;
                        int b;
                        int a1 = 0;
                        int b1 = 0;
                        if (line[1] == "s")
                        {
                            switch (line[3])
                            {
                                case "=="://if[0] s[1] hel[2] ==[3] helt[4] 1[5]
                                    if (line[2] == line[4]) ; else i = i + Convert.ToInt32(line[5]);
                                    break;
                            }
                            break;
                        }
                        if (line[1] == "()" | line[1] == "v" | line[1] == "varsed")
                        {
                            String rt1 = "";//if[0] ()[1] a[2] ==[3] b[4] 1[5]
                            String rt2 = "";
                            foreach (String el1 in var_name)
                            {
                                String g = line[2];
                                if (g == el1)
                                {
                                    rt1 = var_value[use4];
                                    zc++;
                                    use4++;
                                }
                            }
                            foreach (String el1 in var_name)
                            {
                                String g = line[4];
                                if (g == el1)
                                {
                                    rt2 = var_value[use4];
                                    zc++;
                                    use4++;
                                }
                            }
                            if (line[3] == "==")
                            {
                                if (rt1 == rt2) ; else i = i + Convert.ToInt32(line[5]);
                            }
                            else
                            {
                                exceptions.NotOperathorExpected();
                            }
                            break;
                        }
                        use4 = 0;
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if(g == el1)
                            {
                                a1 = Convert.ToInt32(var_value[use4]);
                                zc++;
                                use4++;
                            }
                        }
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if (g == el1)
                            {
                                b1 = Convert.ToInt32(var_value[use4]);
                                zc++;
                                use4++;
                            }
                        }
                        if(zc == 2)
                        {
                            a = a1;
                            b = b1;
                            String ch = line[2];
                            switch (ch)
                            {
                                default:
                                    exceptions.NonQEOperathor();
                                    break;
                                case ">":
                                    if (a > b) ; else i = i + Convert.ToInt32(line[4]);
                                    break;
                                case "<":
                                    if (a < b) ; else i = i + Convert.ToInt32(line[4]);
                                    break;
                                case "==":
                                    if (a == b) ; else i = i + Convert.ToInt32(line[4]);
                                    break;
                                case "!=":
                                    if (a != b) ; else i = i + Convert.ToInt32(line[4]);
                                    break;
                            }
                        }
                        else
                        {
                            a = Convert.ToInt32(line[1]);
                            b = Convert.ToInt32(line[3]);
                            String ch = line[2];
                            switch (ch)
                            {
                                default:
                                    exceptions.NonQEOperathor();
                                    break;
                                case ">":
                                    if (a > b) ; else i++;
                                    break;
                                case "<":
                                    if (a < b) ; else i++;
                                    break;
                                case "==":
                                    if (a == b) ; else i++;
                                    break;
                                case "!=":
                                    if (a != b) ; else i++;
                                    break;
                            }
                        }
                        break;
                    case "calc":
                        int use5 = 0;
                        String ab = "";
                        String ba = "";
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if (el1 == g)
                            {
                                ab = var_value[use5];
                                zc++;
                                use5++;
                                break;
                            }
                        }
                        use5 = 0;
                        foreach (String el1 in var_name)
                        {
                            String g = line[1];
                            if (el1 == g)
                            {
                                ba = var_value[use5];
                                zc++;
                                use5++;
                                break;
                            }
                        }
                        Console.WriteLine(parser.NumberExpression(
                            Convert.ToInt32(ab),
                            Convert.ToChar(line[2]),
                            Convert.ToInt32(ba)));
                        break;
                    case "goto":
                        i = i + Convert.ToInt32(line[1]);
                        goto Label;
                    case "import":
                        if (line[1] == "File")
                        {
                            File_Mod = true;
                        }else if (line[1] == "math")
                        {
                            Math_module = true;
                        }else if (line[1] == "lgl")
                        {
                            LGL_Module = true;
                        }
                        break;//File module command
                    case "create":
                        if (File_Mod)
                        {
                            File.Create(line[1]);
                        }
                        else
                        {
                            exceptions.NonLibraryException();
                        }
                        break;
                    case "writeFile":
                        if (File_Mod)
                        {
                            File.WriteAllText(Directory.GetCurrentDirectory() + line[1], line[2]);
                        }
                        else
                        {
                            exceptions.NonLibraryException();
                        }
                        File.WriteAllText(Directory.GetCurrentDirectory() + line[1], line[2]);
                        break;//math module
                    case "abs":
                        if(Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Abs(parser.ToInt(line[1])));
                        break;
                    case "sin":
                        if (Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Sin(parser.ToInt(line[1])));
                        break;
                    case "cos":
                        if (Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Cos(parser.ToInt(line[1])));
                        break;
                    case "tan":
                        if (Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Tan(parser.ToInt(line[1])));
                        break;
                    case "max":
                        if (Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Max(parser.ToInt(line[1]), parser.ToInt(line[2])));
                        break;
                    case "min":
                        if (Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Min(parser.ToInt(line[1]), parser.ToInt(line[2])));
                        break;
                    case "pow":
                        if (Math_module == false)
                        {
                            exceptions.NonLibraryException();
                        }
                        Console.WriteLine(Math.Pow(parser.ToInt(line[1]), parser.ToInt(line[2])));
                        break;
                    case ";"://unde
                        break;
                    case "close":
                        Environment.Exit(0);
                        break;
                }
                frst++;
            }
            Console.ReadKey();
        }
    }
}
