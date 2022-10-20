// Задание - написать следующие функции:
// 1. Функция, которая вычисляет число a в степени n
// 2. Функция, которая вычисляет факториал числа n
// 3. Функция, которая вычисляет сумму цифр произвольного целого числа n
// 4. Функция, которая проверяет является ли заданное число n полиндромом
// 5. Функция, складывающая два целых числа
// 6. Функция, определяющая является ли число простым, 
// то есть возвращающая true, если число простое, иначе - false
// 7. Функция, определяющая является ли число чётным, 
// то есть возвращающая true, если число чётное, иначе - false

// 1. Функция, которая вычисляет число a в степени n (без стандартной функции)
double Stepen (int number, int stepen)
{
    double st=number;
    if (stepen==0) st=1;
    else if (stepen>0)
        for (int i=1; i<stepen; i++)
            st=st*number;
    else
    {
        stepen=stepen*(-1);
        for (int i=1; i<stepen; i++)
            st=st*number;
        st=1/st;
    }
    return st;
}

// 2. Функция, которая вычисляет факториал числа n
double Factorial (int n)
{
    if ((n==1) | (n==0)) return 1;
    else return n*Factorial(n-1);
}

// 3. Функция, которая вычисляет сумму цифр произвольного целого числа n

// 4. Функция, которая проверяет является ли заданное число n полиндромом

// 5. Функция, складывающая два целых числа
int SumInt(int first, int second)
{
    return (first+second);
}
// 6. Функция, определяющая является ли число простым, 
// то есть возвращающая true, если число простое, иначе - false

// 7. Функция, определяющая является ли число чётным, 
// то есть возвращающая true, если число чётное, иначе - false

Console.WriteLine("Проверка задачи 1");
Console.Write("Введите число, степень которого надо найти: ");
int numb = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Введите степень, в которую надо возвести число {numb}: ");
int step = int.Parse(Console.ReadLine() ?? "0");
if ((numb==0) & (step=0)) Console.Write("задача не имеет смысла");
else Console.WriteLine($"Число {numb} в степени {step}= {Stepen (numb, step)}");
Console.WriteLine("");

Console.WriteLine("Проверка задачи 2");
Console.Write("Введите число, факториал которого нужно вычислить: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Факториал числа {n}! = {Factorial (n)}");
Console.WriteLine("");

Console.WriteLine("Проверка задачи 5");
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма чисел {a} и {b} = {SumInt(a, b)}");
Console.WriteLine("");