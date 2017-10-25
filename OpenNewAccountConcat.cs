//code to insert record using data concat

using System;
using System.Data;
using System.Data.SqlClient;

class OpenNewAccountConcat
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;

int no;
string nm,typ;
double bal;

try
{
Console.Write("Enter account number ");
no=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter name ");
nm=Console.ReadLine();
Console.Write("Enter type ");
typ=Console.ReadLine();
Console.Write("Enter balance ");
bal=Convert.ToDouble(Console.ReadLine());

scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=amazondb0815");

sda=new SqlDataAdapter("insert into accounts values("+no+",'"+nm+"','"+typ+"',"+bal+");",scon);

ds=new DataSet();
sda.Fill(ds);

Console.WriteLine("Account opened successfully");
}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}
}
}

//content of sohamglobal.com




