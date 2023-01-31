Console.Clear();
Console.WriteLine("Введите  число");
int N = int.Parse(Console.ReadLine());
string Value = Convert.ToString(N);
if (Value.Length != 3){
    Console.WriteLine("Вы ввели не правильное число");
}
else{
    Console.WriteLine(Value[1]);
}
int n1 = N/10;
int n2 = n1 % 10;

Console.WriteLine(n2);


