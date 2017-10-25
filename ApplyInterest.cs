//Code to call a non parameterized stored procedure

using System;
using System.Data;
using System.Data.SqlClient;

class ApplyInterest
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;

try
{
scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=volkswagendb");

sda=new SqlDataAdapter("exec updbalance;",scon);
ds=new DataSet();
sda.Fill(ds);
Console.WriteLine("All accounts updated successfully with interest");
}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com