// 1 обЪявить тип переменной, объявляем имя переменной
int inputNumber = Convert.ToInt32(Console.ReadLine());
//Convert.ToInt32(Console.ReadLine());
// int inputNumber = Convert.Parse(Console.ReadLine()); нужно будет еще поправить в csproj Nullable вкл на Disable
int square = inputNumber * inputNumber;

Console.WriteLine(square);
