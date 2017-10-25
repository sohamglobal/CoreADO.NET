//code to call a parameterized stored procedure

/*
create table acccharges(accno int,amount int,
details varchar(100));

create procedure cardcharges
@ano int,
@amt int,
@details varchar(100)
as
begin
insert into acccharges values(@ano,@amt,@details);
update accounts set balance=balance-@amt where accno=@ano;
end;
*/

using System;
using System.Data;
using System.Data.SqlClient;

class AccountCharges
{
public static void Main()
{
SqlConnection scon;
SqlCommand scmd;
SqlDataAdapter sda;
DataSet ds;

int ano,amt;
string det;

try
{
Console.Write("Enter account number ");
ano=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter amount ");
amt=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter deduction details ");
det=Console.ReadLine();

scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=volkswagendb");

scmd=new SqlCommand("exec cardcharges @a,@b,@c;",scon);

scmd.Parameters.AddWithValue("a",ano);
scmd.Parameters.AddWithValue("b",amt);
scmd.Parameters.AddWithValue("c",det);

sda=new SqlDataAdapter(scmd);

ds=new DataSet();
sda.Fill(ds);

Console.WriteLine("SP executed...monthly charges applied to account "+ano);

}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}

//content of sohamglobal.com