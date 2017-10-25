//code to update data after verifying thru select

using System;
using System.Data;
using System.Data.SqlClient;

class UpdateAfterSelect
{
public static void Main()
{
int no;
string typ;
double amt;

SqlConnection scon;
SqlCommand scmd;
SqlDataAdapter sda;
DataSet ds;

try
{
scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=amazondb0815");

ds=new DataSet();

Console.Write("Enter account number ");
no=Convert.ToInt32(Console.ReadLine());

scmd=new SqlCommand("select * from accounts where accno=@a;",scon);

scmd.Parameters.AddWithValue("a",no);
sda=new SqlDataAdapter(scmd);
sda.Fill(ds,"acc");

if(ds.Tables["acc"].Rows.Count>0)
{
Console.Write("Enter transaction type ");
typ=Console.ReadLine();
Console.Write("Enter amount ");
amt=Convert.ToDouble(Console.ReadLine());

if(typ=="deposit")
scmd=new SqlCommand("update accounts set balance=balance+@a where accno=@b;",scon);
else
scmd=new SqlCommand("update accounts set balance=balance-@a where accno=@b;",scon);

scmd.Parameters.AddWithValue("a",amt);
scmd.Parameters.AddWithValue("b",no);

sda=new SqlDataAdapter(scmd);

sda.Fill(ds);

Console.WriteLine("account updated successfully");
}
else
Console.WriteLine("account does not exist");
}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}
}
}

//content of sohamglobal.com