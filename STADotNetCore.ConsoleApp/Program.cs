using System;
using System.Data;
using System.Data.SqlClient;
using STADotNetCore.ConsoleApp;

Console.WriteLine("Hello, World!");

// SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

// stringBuilder.DataSource        = ".";
// stringBuilder.InitialCatalog    = "DotNetTrainingBatch4";
// stringBuilder.UserID            = "sa";
// stringBuilder.Password          = "sasa@123";

// SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

// connection.Open();
// Console.WriteLine("connection open");

// string query = "SELECT * FROM Tbl_Blog";
// SqlCommand cmd = new SqlCommand(query, connection);
// SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
// DataTable dt = new DataTable();
// sqlDataAdapter.Fill(dt);

// connection.Close();
// Console.WriteLine("connection close ");

// foreach (DataRow dr in dt.Rows)
// {
//     Console.WriteLine("Blog Id      => " + dr["BlogId"]);
//     Console.WriteLine("Blog Title   => " + dr["BlogTitle"]);
//     Console.WriteLine("Blog Author  => " + dr["BlogAuthor"]);
//     Console.WriteLine("Blog Content => " + dr["BlogContent"]);
//     Console.WriteLine("-------*******************--------");
// }using System.Data;

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
adoDotNetExample.Create("title", "author", "content");
adoDotNetExample.Read();
Console.ReadKey();