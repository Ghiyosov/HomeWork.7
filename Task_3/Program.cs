
using Task_3;

Date date_1 = new Date(22, 11 , 2003);
Console.WriteLine("Day : " + date_1.GetDay());
Console.WriteLine("Month : " + date_1.GetMonth());
Console.WriteLine("Year : " + date_1.GetYear());
Console.WriteLine(date_1.ToString());
Console.WriteLine();
Console.WriteLine("**********************************");
Console.WriteLine();
date_1.SetDate(33, 13, 2003);
Console.WriteLine("Day : " + date_1.GetDay());
Console.WriteLine("Month : " + date_1.GetMonth());
Console.WriteLine("Year : " + date_1.GetYear());
Console.WriteLine(date_1.ToString());
Console.WriteLine();
Console.WriteLine("**********************************");
Console.WriteLine();

