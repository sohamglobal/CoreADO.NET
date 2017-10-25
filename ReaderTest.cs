//code to use SqlDataReader

using System;
using System.Data.SqlClient;

class ReaderTest
{
public static void Main()
{
SqlConnection con=new SqlConnection("server=DESKTOP-KR5287D\\sqlexpress;uid=sa;pwd=microsoft;database=skodadb");

SqlCommand scmd = new SqlCommand("select * from accounts;", con);
con.Open();

SqlDataReader reader = scmd.ExecuteReader();

while (reader.Read())
{
Console.Write(reader["accnm"] + " | ");
Console.WriteLine(reader["balance"]);
}

reader.Close();
con.Close();
}
}

//content of sohamglobal.com



/*

DataReader

1.The ADO.NET DataReader is used to retrieve read-only(cannot update data back to datasource) and forward-only(cannot read backward/random) data from a database. 
2.Using the DataReader increases application performance and reduces system overheads. This is due to one row at a time is stored in memory.  
3.You create a DataReader by calling Command.ExecuteReader after creating an instance of the Command object.  
4.This is a connected architecture: The data is available as long as the connection with database exists. 
5.You need to open and close the connecton manually in code.


DataSet

1.The DataSet is a in-memory representation of data.  
2.It can be used with multiple data sources. That is A single DataSet can hold the data from different data sources holdng data from different databases/tables. 
3.The DataSet represents a complete set of data including related tables, constraints, and relationships among the tables.  
4.The DataSet can also persist and reload its contents as XML and its schema as XML Schema definition language (XSD) schema. 
5.The DataAdapter acts as a bridge between a DataSet and a data source for retrieving and saving data.  
6.The DataAdapter helps mapping the data in the DataSet to match the data in the data source.  
7.Also, Upon an update of dataset, it allows changing the data in the data source to match the data in the DataSet.  
8.No need to manually open and close connection in code. 
9.Hence, point (8) says that it is a disconnected architecture. Fill the data in DataSet and that's it. No connection existence required
*/