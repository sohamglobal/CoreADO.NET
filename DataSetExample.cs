//code to create dataset programatically

using System;
using System.Data;

class Program
{
    static void Main()
    {
	// Create two DataTable instances.
	DataTable table1 = new DataTable("teams");
	table1.Columns.Add("teamid");
	table1.Columns.Add("teamname");
	table1.Rows.Add(1,"chelsea");
	table1.Rows.Add(2,"liverpool");

	DataTable table2 = new DataTable("players");
	table2.Columns.Add("playername");
	table2.Columns.Add("country");
	table2.Columns.Add("teamid");
	table2.Rows.Add("alvaro morata", "spain",1);
	table2.Rows.Add("edan hazard", "belgium",1);
	table2.Rows.Add("philip coutinho","brazil",2);

	// Create a DataSet and put both tables in it.
	DataSet set = new DataSet("football");
	set.Tables.Add(table1);
	set.Tables.Add(table2);

	// Visualize DataSet.
	Console.WriteLine(set.GetXml());
    }
}

//content of sohamglobal.com