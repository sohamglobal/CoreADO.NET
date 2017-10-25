//code to use paramerized insert query

using System;
using System.Data;
using System.Data.SqlClient;

class OpenNewAccount
{
public static void Main()
{
int no;
string nm,typ;
double bal;

SqlConnection scon;
SqlCommand scmd;
SqlDataAdapter sda;
DataSet ds;

try
{
Console.Write("Enter Account number ");
no=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter name ");
nm=Console.ReadLine();
Console.Write("Enter type ");
typ=Console.ReadLine();
Console.Write("Enter balance ");
bal=Convert.ToDouble(Console.ReadLine());

scon=new SqlConnection("server=desktop-kr5287d\\sqlexpress;uid=sa;pwd=microsoft;database=skodadb");

scmd=new SqlCommand("insert into accounts values(@a,@b,@c,@d);",scon);

scmd.Parameters.AddWithValue("a",no);
scmd.Parameters.AddWithValue("b",nm);
scmd.Parameters.AddWithValue("c",typ);
scmd.Parameters.AddWithValue("d",bal);

sda=new SqlDataAdapter(scmd);

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









