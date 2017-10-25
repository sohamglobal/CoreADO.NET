//code to call a parameterized procedure

/*
create procedure GetPass
@uid varchar(30)
as
begin 
select pswd from users where userid=@uid;
end;
*/

using System;
using System.Data;
using System.Data.SqlClient;

class GetPass
{
public static void Main()
{
SqlConnection scon;
SqlCommand scmd;
SqlDataAdapter sda;
DataSet ds;

string id;

try
{
Console.Write("Enter UserID ");
id=Console.ReadLine();

scon=new SqlConnection("server=spider;uid=sa;pwd=microsoft;database=praffulldb");

scmd=new SqlCommand("exec getpass @a;",scon);

scmd.Parameters.AddWithValue("a",id);

sda=new SqlDataAdapter(scmd);

ds=new DataSet();
sda.Fill(ds,"pass");

if(ds.Tables["pass"].Rows.Count>0)
Console.WriteLine(ds.Tables[0].Rows[0]["pswd"]);
else
Console.WriteLine("User does not exist");

}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com
