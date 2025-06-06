/* //Grade Calculator    
//CH -> Credit Hours
//S-> Subject

// version 1
const double TotalCH = 3 + 3 + 4 + 4 + 3;

Console.WriteLine("S1 Grade:");
double S1= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("S2 Grade:");
double S2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("S3 Grade:");
double S3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("S4 Grade:");
double S4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("S5 Grade:");
double S5 = Convert.ToDouble(Console.ReadLine());

double Total = S1 * 3 + S2 * 3 + S3 * 4 + S4 * 4 + S5 * 3;

Console.WriteLine("Final GPA: "+Total/TotalCH);

 */

//version 2


int[] CH = [3, 3, 4, 4, 3 ];

int[] Sub = new int[5];

int sum = 0;

for (int i = 0; i < 5; i++)
{
    Sub[i] = Convert.ToInt32(Console.ReadLine());
    sum += Sub[i] * CH[i];
}
double Total = sum / CH.Sum();
Console.WriteLine("Total GPA:"+Total);
