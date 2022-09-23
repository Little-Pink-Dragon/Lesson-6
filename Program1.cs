Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());;
int[] numbers = new int[size];
int count = 0;
for (int i = 0; i < size; i++) 
{
   Console.Write("Введите число: ");
numbers[i] = Convert.ToInt32(Console.ReadLine());;
if (numbers[i] > 0)
count++;
}
PrintArray(numbers);
void PrintArray(int[] numbers)
{
    Console.Write("[");
     for(int i = 0; i < numbers.Length; i++)
     { if (i < numbers.Length - 1)
     {
     Console.Write(numbers[i] + ", ");
     }
     else Console.Write(numbers[i] + "");
     }
    Console.Write("]");
    Console.Write(" -> " + count + " - чисел больше 0");
}
