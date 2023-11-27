

string[] name = new string[10];
double[] sales = new double[10];
double[] comm = new double[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(" Enter name " + i);
    name[i] = Console.ReadLine();

    Console.WriteLine(" Enter sales for "  + name[i]);
   sales[i] = Convert.ToDouble(Console.ReadLine());

    comm[i] = sales[i] * 0.0049;


}

Console.WriteLine("===============================");
Console.WriteLine("=======Before sorting==========");
Console.WriteLine("===============================");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Name :" + name[i]);
    Console.WriteLine("Sales :" + sales[i]);
    Console.WriteLine("commission :" + comm[i]);
}

Console.WriteLine("===============================");
Console.WriteLine("=======after sorting==========");
Console.WriteLine("===============================");



for (int stloop = 0; stloop < 10; stloop++)
{
    for (int y = 0; y < 9; y++)
    {
        if (comm[y] > comm[y + 1])
        {
            string tempName = name[y];
            name[y] = name[y + 1];
            name[y + 1] = tempName;

            double tempSales = sales[y];
            sales[y] = sales[y + 1];
            sales[y + 1] = tempSales;

            double tempComm = comm[y];
            comm[y] = comm[y + 1];
            comm[y + 1] = tempComm;
        }
    }
}



for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Name :" + name[i]);
    Console.WriteLine("Sales :" + sales[i]);
    Console.WriteLine("Commission :" + comm[i]);
}
