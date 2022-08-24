// (Вводим с помощью клавиатуры, т.е. через консоль)
Console.Write ("Введите число элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [length];
for (int i = 0; i < array.Length; i++)
    {
      Console.Write ("Введите элемент массива под индексом "+i+": ");
      array [i] = Convert.ToInt32 (Console.ReadLine ());
    }

for (int i = 0; i < array.Length; i++)
    {
          Console.Write (array[i]);
          if (i!=array.Length - 1)
            {
              Console.Write (", ");
            }
    }