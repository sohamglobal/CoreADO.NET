//code for using view

using System;
using System.Data;
using System.Data.SqlClient;

class DataFromView
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;
int cnt=0,i,intr;
string nm;

try
{
scon=new SqlConnection("server=DESKTOP-KR5287D\\SQLEXPRESS;uid=sa;pwd=microsoft;database=skodadb");

sda=new SqlDataAdapter("select accnm,interest from savingdata;",scon);
ds=new DataSet();
sda.Fill(ds,"view");

cnt=ds.Tables["view"].Rows.Count;
Console.WriteLine("Number of records retrieved : {0}",cnt);

for(i=0;i<cnt;i++)
{
nm=Convert.ToString(ds.Tables["view"].Rows[i]["accnm"]);
intr=Convert.ToInt32(ds.Tables["view"].Rows[i]["interest"]);
Console.WriteLine(nm+"\t"+intr);
}

}
catch(Exception e)
{
Console.WriteLine("Error in ADO.NET "+e.Message);
}

}
}

//content of sohamglobal.com





