static string[] FilterArrayStrings(string[] inputArray)
{
  int count = 0;
  for (int i = 0; i < inputArray.Length; i++)
  {
    if (inputArray[i].Length <= 3)
    {
      count++;
    }
  }

  string[] newArray = new string[count];
  count = 0;
  for (int i = 0; i < inputArray.Length; i++)
  {
    if (inputArray[i].Length <= 3)
    {
      newArray[count] = inputArray[i];
      count++;
    }
  }

  return newArray;
}

void ShowArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

Console.Write("Input number of elements in the array: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] inputArray = new string[num];
for (int i = 0; i < inputArray.Length; i++)
{
  Console.Write($"Input {i + 1} string: ");
  inputArray[i] = Console.ReadLine();
}

string[] newArray = FilterArrayStrings(inputArray);

Console.WriteLine("Strings with length less than or equal to 3:");
ShowArray(newArray);