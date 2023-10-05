string s = "бiологiя алгебра iсторiя географiя геометрiя";
string c = "i";
string[] a;
a = s.Split(' ');
int i;
for(i = 0; i < a.Length; i++)
{
    int t = a[i].IndexOf(c);
    if (t != -1) Console.WriteLine(a[i]);
}
Console.ReadKey();