
string input = "C:\\Users\\Ziggy\\Documents\\";
//string[] result = input.Split('\\');
string[] result = input.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

if (result.Length > 0)
{
    foreach (string output in result)
    {
        Console.WriteLine(output);
    }
}

Console.ReadLine();



