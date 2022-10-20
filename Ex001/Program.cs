//  Реализовать следующие функции для работы с массивами:
//  1. Поиск минимума
//  2. Поиск максимума
//  3. Поиск суммы элементов массива
//  4. Поиск произведения элементов массива
//  5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
//  6. Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
//  7. Печать массива на экран
//  8. Среднее арифметическое элеметов массива
//  9. Подсчёт количества отрицательных элементов массива
//  10. Подсчёт количества вхождений элемента в массив
//  11. Подсчёт количества чётных элементов в массиве
//  12. Подсчёт количества положительных элементов в массиве
//  13. Подсчёт количества нечётных элементов в массиве
//  14. Проверка является ли массив отсортированным по возрастанию. 
//      Если массив отсортирован, то возвращать true, иначе - false.

// Реализация заполнения массива с параметрами, заданными пользователем
void GenerateMassiv(int [] array, int min, int max)
{
    Random random = new Random();
    for (int i=0; i<array.Length; i++)
        array[i] = new Random().Next(min,max);
}

// 1. Поиск минимума, найденное значение возвращаем в min
int MinElement(int [] array)
{
    int min = array[0];
    foreach (int element in array)
        if (min>element) min = element;
    return min;
}

//  2. Поиск максимума, найденное значение возвращаем в max
int MaxElement(int[] array)
{
    int max = array[0];
    foreach (int element in array)
        if (max<element) max = element;
    return max;
}

//  3. Поиск суммы элементов массива, найденное значение возвращаем в sum
int SumElement(int[] array)
{
    int sum = 0;
    foreach (int element in array)
        sum+=element;
    return sum;
}

//  4. Поиск произведения элементов массива, найденное значение возвращаем в mult
double MultElement(int[] array)
{
    double mult = 1;
    foreach (int element in array)
        mult*=element;
    return mult;
}

//  5. Поиск индекса заданного элемента в массиве, 
//     если такого элемента в массиве нет то возвращаем -1
int FindIndex(int[] array, int find_elem)
{
    int ind_el = -1;    
    for (int i=0; i < array.Length; i++) 
        if (array[i]==find_elem) 
        {
            ind_el=i;
            break;
        }
    return ind_el;
}

//  6. Проверка наличия элемента в массиве. 
//     Возвращает true, если элемент в массиве есть, false – нет.
bool FindElement(int[] array, int element)
{
    bool fl_find=false;
    for (int i=0; i < array.Length; i++) 
        if (array[i]==element) 
        {
            fl_find = true;
            break;
        }
    return fl_find;
}

// 7. Печать массива на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}"+"; ");
        }
    Console.WriteLine();
}

//  8. Среднее арифметическое элеметов массива
//  Найденное среднее арифм. возвращаем в SrednAr
float SrednArifm(int[] array)
{
    float sum = 0;
    foreach (int element in array)
        sum=sum+element;
    float SrednAr = sum/array.Length;
    return SrednAr;
}

//  9. Подсчёт количества отрицательных элементов массива
// Найденное количество возвращаем в count
int CountOtr(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element<0)
            count++;
    return count;
}

//  10. Подсчёт количества вхождений элемента в массив, результат возвращаем в CountFind
int CountFindElement(int[] array, int find_el)
{
    int CountFind = 0;
    foreach (int element in array)
        if (element==find_el) 
            CountFind++;
    return CountFind;
}

//  11. Подсчёт количества чётных элементов в массиве, результат возвращаем в count
int CountChetn(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element%2==0)
            count++;
    return count;
}

//  12. Подсчёт количества положительных элементов в массиве
// Найденное количество возвращаем в count
int CountPol(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element>=0)
            count++;
    return count;
}

//  13. Подсчёт количества нечётных элементов в массиве, результат возвращаем в count
int CountNoChetn(int[] array)
{
    int count = 0;
    foreach (int element in array)
        if (element%2!=0)
            count++;
    return count;
}

//  14. Проверка является ли массив отсортированным по возрастанию. 
//      Если массив отсортирован, то возвращать true, иначе - false.
bool FindSort(int[] array)
{
    bool fl_sort=false;
    for (int i=0; i < (array.Length-1); i++) 
    {
        if (array[i]<array[i+1]) 
            fl_sort = true;
        else 
        {
            fl_sort=false;
            break;
        }
    }
    return fl_sort;
}

// Для проверки задания 14, сортируем наш массив
void ArraySort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinIndex = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[MinIndex]) MinIndex = j;
            {
                MinIndex = j;
            }
        }
        int temp = array[i];
        array[i] = array[MinIndex];
        array[MinIndex] = temp;
    }
}

// Запрашиваем у пользователя необходимые данные для создания массива
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
if (length == 0) 
{
    length=10;
    Console.WriteLine($"Так как введенное значение = 0, за размер массива примем число {length}");
}
Console.Write("Введите минимальный элемент: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент: ");
int max = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[length]; // инициализируем массив

GenerateMassiv(array, min, max); // заполняем массив элементами


Console.WriteLine("Задание 7. Наш массив:");
PrintArray(array); // выводим массив на экран

Console.WriteLine($"Задание 1. Минимальный элемент в массиве : {MinElement(array)}");
Console.WriteLine($"Задание 2. Максимальный элемент в массиве : {MaxElement(array)}");
Console.WriteLine($"Задание 3. Сумма элементов в массиве : {SumElement(array)}");
Console.WriteLine($"Задание 4. Произведение элементов в массиве : {MultElement(array)}");
Console.WriteLine($"Задание 8. Среднее арифметическое элементов : {SrednArifm(array)}");
Console.WriteLine($"Задание 9. Количество отрицательных элементов : {CountOtr(array)}");
Console.WriteLine($"Задание 11. Количество четных элементов : {CountChetn(array)}");
Console.WriteLine($"Задание 12. Количество положительных элементов : {CountPol(array)}");
Console.WriteLine($"Задание 13. Количество нечетных элементов : {CountNoChetn(array)}");

// запрашиваем элемент для поиска его индекса в массиве (Задание 5)
Console.Write("Задание 5. Введите искомый элемент для поиска его индекса: ");
int find_index_elem = int.Parse(Console.ReadLine() ?? "0");
int index_element = FindIndex(array, find_index_elem); // выполняем поиск индекса элемента 
if (index_element==-1) 
    Console.WriteLine($"Задание 5. Искомый элемент ({find_index_elem}) в массиве не найден");
else 
    Console.WriteLine($"Задание 5. Искомый элемент ({find_index_elem}) в массиве имеет индекс = {index_element}");

// запрашиваем элемент для поиска в массиве (Задание 6/Задание 10)
Console.Write("Задание 6. Введите элемент, который надо найти в массиве: ");
int elem = int.Parse(Console.ReadLine() ?? "0");
if (FindElement(array, elem)==false) 
{
    Console.WriteLine($"Задание 6. Искомый элемент ({elem}) в массиве не найден ");
    Console.WriteLine($"Задание 10. Искомых элементов ({elem}) в массиве = {CountFindElement(array, elem)}");
}
else 
{
    Console.WriteLine($"Задание 6. Искомый элемент ({elem}) в массиве найден");
    Console.WriteLine($"Задание 10. Искомых элементов ({elem}) в массиве = {CountFindElement(array, elem)}");
}

if (FindSort(array)==false) 
    Console.WriteLine("Задание 14. Массив не отсортирован по возрастанию");
else 
    Console.WriteLine("Задание 14. Массив отсортирован по возрастанию");
// Проверка задания 14 на принудительно отсортированном массиве
ArraySort(array);
Console.WriteLine("Проверка задания 14. Отсортированный массив:");
PrintArray(array); // выводим массив на экран
if (FindSort(array)==false) 
    Console.WriteLine("Задание 14. Массив не отсортирован по возрастанию");
else 
    Console.WriteLine("Задание 14. Массив отсортирован по возрастанию");