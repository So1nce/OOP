string s1 = "бiологiя алгебра iсторiя географiя геометрiя";
string[] a;
a = s1.Split(' ');
Array.Reverse(a);
string s2 = string.Join(" ", a);
Console.WriteLine(s2);
Console.ReadKey();