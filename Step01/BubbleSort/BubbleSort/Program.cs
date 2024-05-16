
List<int> list = new List<int>();

Console.WriteLine("Please enter the number of elements :");
int numbers = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter the Elements : ");
for (int i = 0; i < numbers; i++)
{
    list.Add(Int32.Parse(Console.ReadLine()));
}

BubbleSort(list);

#region [- BubbleSort(List<int> input) -]
void BubbleSort(List<int> input)
{
    int temporary;

    for (int j = 0; j <= input.Count - 2; j++)
    {
        for (int i = 0; i <= input.Count - 2; i++)
        {
            if (list[i] > list[i + 1])
            {
                temporary = input[i + 1];
                input[i + 1] = input[i];
                input[i] = temporary;
            }
        }
    }

    Console.WriteLine("Sorted:");
    foreach (int p in input)
    {
        Console.Write($"{p} ");
    }
} 
#endregion

Console.ReadLine();