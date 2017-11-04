using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arr = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] query = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (query[0] == "reverse")
                {
                    int reverseStart = int.Parse(query[2]);
                    int reverseCount = int.Parse(query[4]);
                    if (reverseStart < 0 || reverseStart >= arr.Count ||
                        reverseCount > arr.Count - reverseStart || reverseCount < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    for (int i = 0; i < reverseCount / 2; ++i)
                    {
                        string temp = arr[i + reverseStart];
                        arr[i + reverseStart] = arr[reverseStart + reverseCount - 1 - i];
                        arr[reverseStart + reverseCount - 1 - i] = temp;
                    }
                }
                else if (query[0] == "sort")
                {
                    int sortStart = int.Parse(query[2]);
                    int sortCount = int.Parse(query[4]);
                    if (sortStart < 0 || sortStart >= arr.Count ||
                        sortCount > arr.Count - sortStart || sortCount < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    string[] portionToSort = arr
                        .Where((x, i) => i >= sortStart && i < sortStart + sortCount)
                        .OrderBy(x => x)
                        .ToArray();
                    for (int i = 0; i < sortCount; i++)
                    {
                        arr[i + sortStart] = portionToSort[i];
                    }
                }
                else if (query[0] == "rollLeft")
                {
                    int rollLeftCount = int.Parse(query[1]);
                    if (rollLeftCount < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    if (rollLeftCount % arr.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        rollLeftCount = rollLeftCount % arr.Count;
                    }
                    string temp = "";
                    while (rollLeftCount > 0)
                    {

                        for (int i = 0; i < arr.Count; i++)
                        {

                            if (i == 0)
                            {
                                temp = arr[i];
                            }
                            else if (i == arr.Count - 1)
                            {
                                arr[i] = temp;
                                break;

                            }
                            arr[i] = arr[i + 1];

                        }
                        --rollLeftCount;
                    }

                }
                else if (query[0] == "rollRight")
                {
                    int rollRightCounter = int.Parse(query[1]);
                    if (rollRightCounter < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                    if (rollRightCounter % arr.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        rollRightCounter = rollRightCounter % arr.Count;
                    }
                    string temp = "";
                    while (rollRightCounter > 0)
                    {
                        for (int i = arr.Count - 1; i >= 0; --i)
                        {
                            if (i == arr.Count - 1)
                            {
                                temp = arr[arr.Count - 1];
                            }
                            else if (i == 0)
                            {
                                arr[i] = temp;
                                break;
                            }
                            arr[i] = arr[i - 1];
                        }
                        --rollRightCounter;
                    }
                }

            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }
}
