// 4. Функция, которая проверяет является ли заданное число n полиндромом

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
int SumNumb (int number)
{
    int SumInt=0;
    if ((number>=0) & (number<10)) SumInt=number;
    else
    {
        if (number<0) number=number*(-1);
        while (number>0)
        {
            SumInt=SumInt+(number%10);
            number=number/10;
        }
    }
    return SumInt;
}

// 4. Функция, которая проверяет является ли заданное число n полиндромом
bool Polindrom (int number)
{
    bool fl = false;
    int temp=number; // переменная для изменения временного хранилища, не трогая введенное число
    int razryad=0;
    int delitel=1;
    while (temp>0)
    {
        temp=temp/10;
        razryad++; // определяем разрядность числа
        delitel=delitel*10;
    }

    if (razryad<2) fl = false;
    else
    {      
        int last;
        int first;
        temp=number; // для изменения временного хранилища, не трогая введенное число
        for (int i=1; i<=(razryad/2); i++)
        {
            delitel=delitel/10;
            last=temp%10;
            first=(temp/delitel)%10;
            if (first==last)
            {
                fl = true;
                temp=temp/10;
                delitel=delitel/10;
            }
            else
            {
                fl = false;
                break;
            }
        }
    }
    return fl;
}

// 5. Функция, складывающая два целых числа
int SumInt(int first, int second)
{
    return (first+second);
}

// 6. Функция, определяющая является ли число простым, 
// то есть возвращающая true, если число простое, иначе - false

// 7. Функция, определяющая является ли число чётным, 
// то есть возвращающая true, если число чётное, иначе - false

/*
Console.WriteLine("Проверка задачи 1");
Console.Write("Введите число, степень которого надо найти: ");
int numb = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Введите степень, в которую надо возвести число {numb}: ");
int step = int.Parse(Console.ReadLine() ?? "0");
if ((numb==0) & (step==0)) Console.Write("задача не имеет смысла");
else Console.WriteLine($"Число {numb} в степени {step} = {Stepen (numb, step)}");
Console.WriteLine("");

Console.WriteLine("Проверка задачи 2");
Console.Write("Введите число, факториал которого нужно вычислить: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Факториал числа {n}! = {Factorial (n)}");
Console.WriteLine("");

Console.WriteLine("Проверка задачи 3");
Console.Write("Введите число, сумму цифр которого нужно вычислить: ");
int n_sum = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма цифр числа {n_sum} = {SumNumb (n_sum)}");
Console.WriteLine("");
*/

Console.WriteLine("Проверка задачи 4");
Console.Write("Введите число, проверяемое на полиндромность: ");
int n_polidrom = int.Parse(Console.ReadLine() ?? "0");
if (Polindrom(n_polidrom)==true)
    Console.WriteLine($"Число {n_polidrom} является полиндромом");
else
    Console.WriteLine($"Число {n_polidrom} не является полиндромом");
Console.WriteLine("");

/*
Console.WriteLine("Проверка задачи 5");
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма чисел {a} и {b} = {SumInt(a, b)}");
Console.WriteLine("");
*/