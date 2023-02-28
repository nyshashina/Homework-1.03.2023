// Из имеющегося массива строк формировать массив строк, длина которых меньше, либо равна 3 символам
void ThreeSymEls(string newstring)
{
    char[] separators = new char[] {'"'};
    string[] subs = newstring.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    string[] otherstring = new string[subs.Length];
    for(int i = 0; i < subs.Length; i++)
    {
        if(subs[i].Length <= 3 && subs[i] != " ")
        {
            otherstring[i] = subs[i];
        }
        Console.Write($"{otherstring[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите строки массива, разделив их кавычками");
string str1 = Console.ReadLine () ?? "0";
ThreeSymEls(str1);