


string[] AskArray() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int CheckArray(string[] input, int find)
 {
    int count = 0;

    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= find) 
        {
            count++;
        }
    }

    return count;
}

string[] FindLessThan(string[] input, int find) 
{
    string[] output = new string[CheckArray(input, find)];

    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= find) 
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int find = 3;
string[] array = AskArray();
string[] result = FindLessThan(array, find);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

