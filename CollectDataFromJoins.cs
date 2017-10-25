//Code to use database joins

using System;
using System.Data;
using System.Data.SqlClient;

class CollectDataFromJoins
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;

int cnt=0,i;
string cnm,pnm;

try
{
scon=new SqlConnection("server=sohamglobal\\SQLEXPRESS;uid=sa;pwd=microsoft;database=volkswagendb");

sda=new SqlDataAdapter("select customers.custnm,products.prodnm from customers inner join products on customers.prodid=products.prodid;",scon);
ds=new DataSet();
sda.Fill(ds,"join");

cnt=ds.Tables["join"].Rows.Count;
Console.WriteLine("Number of records retrieved : {0}",cnt);

for(i=0;i<cnt;i++)
{
cnm=Convert.ToString(ds.Tables["join"].Rows[i]["custnm"]);
pnm=Convert.ToString(ds.Tables["join"].Rows[i]["prodnm"]);
Console.WriteLine(cnm+"\t"+pnm);
}

}
catch(Exception e)
{
Console.WriteLine("Error in ADO.NET "+e.Message);
}

}
}

//content of sohamglobal.com





