//Code to create a table on online cloud DB

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


try
{
scon = new SqlConnection("server=cloudnrain.sohamglobal.in;uid=ethanhunt;pwd=microsoft;database=onlinemssqldb");

sda =new SqlDataAdapter("create table accounts(accno int primary key,accnm varchar(30),acctype varchar(10) not null,balance float check(balance>=500));",scon);

ds=new DataSet();
sda.Fill(ds,"us");

Console.WriteLine("table created successfully");


}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com







