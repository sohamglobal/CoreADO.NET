//code to connect to local SQL server and fire select query

using System;
using System.Data;
using System.Data.SqlClient;

class ConnectToSQLServer
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;
int cnt=0,i,bal;
string nm;

try
{
scon=new SqlConnection("server=sohamglobal\\SQLEXPRESS;uid=sa;pwd=microsoft;database=volkswagendb");

sda=new SqlDataAdapter("select * from accounts order by accnm;",scon);
ds=new DataSet();
sda.Fill(ds,"acc");

cnt=ds.Tables["acc"].Rows.Count;
Console.WriteLine("Number of records retrieved : {0}",cnt);

for(i=0;i<cnt;i++)
{
nm=Convert.ToString(ds.Tables["acc"].Rows[i]["accnm"]);
bal=Convert.ToInt32(ds.Tables["acc"].Rows[i]["balance"]);
Console.WriteLine(nm+"\t"+bal);
}

}
catch(Exception e)
{
Console.WriteLine("Error in ADO.NET "+e.Message);
}

}
}






