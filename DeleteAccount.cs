//Code to delete a record

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

try
{
Console.Write("Enter account number to delete ");
no=Convert.ToInt32(Console.ReadLine());

scon=new SqlConnection("server=DESKTOP-KR5287D\\sqlexpress;uid=sa;pwd=microsoft;database=skodadb");

scon.Open();
scmd=new SqlCommand("delete from accounts where accno=@a;",scon);
scmd.Parameters.AddWithValue("a",no);

int cnt=scmd.ExecuteNonQuery();
if(cnt>0)
Console.WriteLine("Account deleted successfully");
else
Console.WriteLine("Account does not exist");

scmd.Dispose();
scon.Close();
}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}
}
}

//content of sohamglobal.com