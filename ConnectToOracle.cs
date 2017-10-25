//Code to connect to Oracle using Oracle.ManagedDataAccess.DLL

using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;

class ConnectToOracle
{
    OracleConnection ocon;
    OracleDataAdapter oda;
    DataSet ds;
    string constr,nm;
    int bal;

public static void Main()
    {
        try
        {
            constr = "Data Source =(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=skodadb;Password=engine;";
            ocon = new OracleConnection(constr);
            oda = new OracleDataAdapter("select * from accounts",ocon);
            ds = new DataSet();

            oda.Fill(ds,"acc");

	    cnt=ds.Tables["acc"].Rows.Count;
	    Console.WriteLine("Number of records retrieved : {0}",cnt);

	    for(i=0;i<cnt;i++)
	    {
		nm=Convert.ToString(ds.Tables["acc"].Rows[i]["accnm"]);
		bal=Convert.ToInt32(ds.Tables["acc"].Rows[i]["balance"]);
		Console.WriteLine(nm+"\t"+bal);
	    }


        }
        catch(Exception ex)
        {
            Response.Write("Error in connection : "+ex.Message);
        }
    }
}

//content of sohamglobal.com