// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучш обойтись исключительно массивами


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine(); //запомнили введеный текст в elements
Console.WriteLine ($"Введеная строка в виде строки {elements}"); //вывели на экран то, что ввёл пользователь


string[] GetArrayFromString(string stringArray)
{
  string[] StringText = stringArray.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
  string[] res = new string[StringText.Length];

  for (int i = 0; i < StringText.Length; i++)
  {
    res[i]=(StringText[i]);
  }
  return res;
}


Console.WriteLine($"Введенный массив {String.Join(" ", GetArrayFromString(elements))}");//вывод на экран элементы массива
string[] InTextArray = GetArrayFromString(elements);

string[] GetArrayThree(string stringArray)
{ 
  int Len=4;
  int LenThreeArray = 0;
  string[] StringText = stringArray.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
  for (int i = 0; i < StringText.Length; i++)
  {
    if (StringText[i].Length < Len)
    LenThreeArray=LenThreeArray+1;
  }
  ;

  string[] Three = new string[LenThreeArray];

//Console.WriteLine(LenThreeArray); //если раскомментировать строку - она выводится два раза - не понимаю, почему
int j=0;//переменная для вставки в массив
  for (int i = 0; i < StringText.Length; i++)
  {
    if (StringText[i].Length < Len)
    {
      Three[j]=(StringText[i]);
      j++;
    }
    
  }
  return Three;
};

string[] StringText = GetArrayThree(elements);


Console.WriteLine($"<3 элементов {String.Join(" , ", GetArrayThree(elements))}");//вывод на экран элементы массива