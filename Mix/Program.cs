// создать массив

int[] CreateArray(int size)
{
    return new int[size];
}


// Ввод данных
int Input(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

// Заполнение руками
  void FillByUser(int[] array)
  {
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
      array[index] = Input("Введите array[" + index + "]: ");
      index++;
    }
  }

  //Mix
void Mix(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        int i = index;
        int j = new Random().Next(i + 1);
        index++;
        {
            int tmp = array[j];
            array[j] = array[i];
            array[i] = tmp;
        }
    }
}

// Печать
  void Print1(int[] array)
  {
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
      Console.Write(array[index] + " ");
      index++;
    }
    System.Console.WriteLine();
  }



int count = Input("Введите размер массива ");
int[] numbers = CreateArray(count);
Print1(numbers);
FillByUser(numbers);
Print1(numbers);
Mix(numbers);
Print1(numbers);

