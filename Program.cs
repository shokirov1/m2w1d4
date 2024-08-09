using m2w1d4.Task1;
using m2w1d4.Task2;
using m2w1d4.Task3;
using m2w1d4.Task4;
using m2w1d4.Task5;
using m2w1d4.Task6;

//Task-1
Console.WriteLine();
Console.WriteLine("-----------------Task-1-----------------");
Console.WriteLine();
Task1 task1 = new Task1();
Console.WriteLine(task1.Palindrome("madam"));

//Task-2
Console.WriteLine();
Console.WriteLine("-----------------Task-2-----------------");
Console.WriteLine();
Task2 task2 = new Task2();
task2.ToUpper("Это тест");

//Task-3
Console.WriteLine();
Console.WriteLine("-----------------Task-3-----------------");
Console.WriteLine();
Task3 task3 = new Task3();
Console.WriteLine(task3.Palindrome("madam"));

//Task-4
Console.WriteLine();
Console.WriteLine("-----------------Task-4-----------------");
Console.WriteLine();
Task4 task4 = new Task4();
task4.Methodstring();
task4.MethodStringBuilder();

//Task-5
Console.WriteLine();
Console.WriteLine("-----------------Task-5-----------------");
Console.WriteLine();
Task5 task5 = new Task5();
task5.DateTimeShow();

//Task-6
Console.WriteLine();
Console.WriteLine("-----------------Task-6-----------------");
Console.WriteLine();
Task6 task6 = new Task6();
task6.DateTimeShow();

Console.WriteLine();
Console.WriteLine("----------------------------------------");
Console.ReadKey();
