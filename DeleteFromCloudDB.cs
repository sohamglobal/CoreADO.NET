//delete data from online database

using System;
using System.Data;
using System.Data.SqlClient;

class ConnectToCloudDB
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;
string nm;


try
{

Console.Write("Enter user name ");
nm=Console.ReadLine();

scon = new SqlConnection("server=cloudnrain.sohamglobal.in;uid=ethanhunt;pwd=microsoft;database=onlinemssqldb");

sda =new SqlDataAdapter("delete from users where usernm='"+nm+"';",scon);

ds=new DataSet();
sda.Fill(ds);

Console.WriteLine("account deleted successfully");

}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com







