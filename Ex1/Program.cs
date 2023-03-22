// 1 обЪявить тип переменной, объявляем имя переменной
int inputNumber = Convert.ToInt32(Console.ReadLine());
//Convert.ToInt32(Console.ReadLine());
// int inputNumber = Convert.Parse(Console.ReadLine()); нужно будет еще поправить в csproj Nullable вкл на Disable
//int square = inputNumber * inputNumber;
int square = Convert.ToInt32(Math.Pow(inputNumber, 10)) ;

Console.WriteLine(square);
