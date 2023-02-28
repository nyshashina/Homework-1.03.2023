// Из имеющегося массива строк формировать массив строк, длина которых меньше, либо равна 3 символам
void ThreeSymEls(string newstring)
{
    char[] separators = new char[] {'"'};
    string[] subs = newstring.Split(separators, StringSplitOptions.RemoveEmptyEntries);

    int count = 0;
    for(int i = 0; i < subs.Length; i++)
    {
        if(subs[i].Length <= 3 && subs[i] != " ")
        {
            count++;
        }
    }

    string[] otherstring = new string[count];
    count = 0;

    for(int i = 0; i < subs.Length; i++)
    {
        if(subs[i].Length <= 3 && subs[i] != " ")
        {
            otherstring[count] = subs[i];
            count++;
        }
    }
    
    foreach(string el in otherstring)
    {
        Console.Write($"{el} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите строки массива, разделив их кавычками");
string str1 = Console.ReadLine () ?? "0";
ThreeSymEls(str1);