//Code to call a stored procedure

/*
create procedure updbalance
as
begin
update accounts set balance=balance+(balance*3/100)
where acctype='saving';
update accounts set balance=balance+(balance*4/100)
where acctype='current';
update accounts set balance=balance+(balance*7/100)
where acctype='fixed';
end;
*/

using System;
using System.Data;
using System.Data.SqlClient;

class CallSPForInterest
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

Console.WriteLine("SP executed...all balances updated");

}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com







