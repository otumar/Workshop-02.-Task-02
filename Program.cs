//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100,1000);
System.Console.WriteLine(number);

int number1 = number / 100;
int number3 = number % 10;

System.Console.WriteLine ($"{number1}{number3}");