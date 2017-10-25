//Example code for update query

using System;
using System.Data;
using System.Data.SqlClient;

class AccountTransactions
{
public static void Main()
{
int no;
string trtyp;
double amt;

SqlConnection scon;
SqlCommand scmd;

try
{
Console.Write("Enter account number ");
no=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter transaction type ");
trtyp=Console.ReadLine();
Console.Write("Enter Amount ");
amt=Convert.ToDouble(Console.ReadLine());

scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=volkswagendb");

scon.Open();

if(trtyp=="deposit")
scmd=new SqlCommand("update accounts set balance=balance+@a where accno=@b;",scon);
else
scmd=new SqlCommand("update accounts set balance=balance-@a where accno=@b;",scon);


scmd.Parameters.AddWithValue("a",amt);
scmd.Parameters.AddWithValue("b",no);

int cnt=scmd.ExecuteNonQuery();

if(cnt>0)
Console.WriteLine("Balance updated successfully");
else
Console.WriteLine("Account does not exist...Sorry transaction failed");

scmd.Dispose();
scon.Close();

}
catch(Exception)
{
Console.WriteLine("invalid input or insufficient funds in the account");
}

}
}

//content of sohamglobal.com
