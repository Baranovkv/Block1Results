Console.WriteLine("Enter array elements separated by commas");
string [] array = Console.ReadLine().Split(", ");
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length < 6)
        count ++;
Console.WriteLine(count);
Console.Write("[");
if (count > 0)
{
    int j = 0;
    string[] arrayResult = new string [count];
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length < 6)
        {
            arrayResult[j] = array[i];
            j++;
        }
    for (int i = 0; i < count-1; i++)
        Console.Write($"\"{arrayResult[i]}\" ");
    Console.Write($"\"{arrayResult[arrayResult.Length-1]}\"]");
}    
else 
    Console.Write("]"); 