//напишите программу, которая из имеющегося массива строк формирует массив строк, длина
//которых меньше, либо равна 3 символа


string[] array =
{
    "3","-5","r","edr","-432","ww","3456",
    "3212",":)"
};

var result = new string[array.Length];
var Size = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[Size] = value;
        Size++;
    }
}
System.Console.WriteLine(string.Join(Environment.NewLine, result, 0, Size));


