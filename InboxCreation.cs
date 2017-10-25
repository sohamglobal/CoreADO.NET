//code to fire DDL create query

using System;
using System.Data;
using System.Data.SqlClient;

class InboxCreation
{
public static void Main()
{
string uid;
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;

try
{
Console.Write("Enter userID ");
uid=Console.ReadLine();

scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=amazondb0815");

sda=new SqlDataAdapter("create table "+uid+"inbox (msgno int identity(1,1),msgfrm varchar(30),subject varchar(100),msgtext varchar(1000) not null,msgstatus varchar(15) default 'unread');" ,scon);

ds=new DataSet();
sda.Fill(ds);

Console.WriteLine("inbox table for "+uid+" created successfully");
}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}
}
}

//content of sohamglobal.com










