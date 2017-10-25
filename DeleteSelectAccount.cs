//code to delete account

using System;
using System.Data;
using System.Data.SqlClient;

class DeleteAccount
{
public static void Main()
{
int no;

SqlConnection scon;
SqlCommand scmd;
SqlDataAdapter sda;
DataSet ds;

try
{
scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=amazondb0815");

ds=new DataSet();

Console.Write("Enter account number to delete ");
no=Convert.ToInt32(Console.ReadLine());

scmd=new SqlCommand("select * from accounts where accno=@a;",scon);

scmd.Parameters.AddWithValue("a",no);
sda=new SqlDataAdapter(scmd);
sda.Fill(ds,"acc");

if(ds.Tables["acc"].Rows.Count>0)
{
scmd=new SqlCommand("delete from accounts where accno=@a;",scon);

scmd.Parameters.AddWithValue("a",no);
sda=new SqlDataAdapter(scmd);

sda.Fill(ds);

Console.WriteLine("account deleted successfully");
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