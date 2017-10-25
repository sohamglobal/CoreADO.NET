//Code to fire DDL drop query

using System;
using System.Data;
using System.Data.SqlClient;

class CompanyRemoval
{
public static void Main()
{
string compid;
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;

try
{
Console.Write("Enter company ID ");
compid=Console.ReadLine();

scon=new SqlConnection("server=sohamglobal\\SQLEXPRESS;uid=sa;pwd=microsoft;database=volkswagendb");

//sda=new SqlDataAdapter("create table "+compid+"(prodid varchar(10) primary key,prodnm varchar(50),category varchar(15) not null,madein varchar(20) default 'germany',price float);",scon);

sda=new SqlDataAdapter("drop table "+compid+";",scon);


ds=new DataSet();
sda.Fill(ds);

Console.WriteLine("Table created successfully");
}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com