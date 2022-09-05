// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

  int SumX(int x){
    
    int counter = Convert.ToString(x).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      adv = x - x % 10;
      result = result + (x - adv);
      x = x / 10;
    }
   return result;
  }

int sumX = SumX(x);
Console.WriteLine("Сумма цифр в числе: " + sumX);
