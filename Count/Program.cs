//дан массив: наполнени числами от 1 до N
//Задача:выяснить сколько раз какое число встречается

// задан массив +
int[] numbers = { 1, 3, 1, 2, 1, 2, 4, 5, 1, 2, 5, 4 }; 
int length = numbers.Length;


// ввод данных пользователем +
int Input(string number)
{
    Console.Write(number + " ");
    return Convert.ToInt32(Console.ReadLine());
}

// вывод количества раз +
void Find(int[] numbers)
{
    int index = 0;
    int count = 0;
    int number = Input("Введите число: ");

    for (index = 0; index < numbers.Length; index++)
        {
            if (number == numbers[index])
            count = count + 1;
        }
        
        Console.WriteLine(count + " повтора");
            
    }
Find(numbers);