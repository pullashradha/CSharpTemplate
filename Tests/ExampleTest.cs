using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace NameofProjectDefaultValueMakeSureToChangeWhenStartingANewProject!!
{
  public class ExampleTest : IDisposable
  {
    public ExampleTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=database_name_test;Integrated Security=SSPI;";
    }
    public void Dispose()
    {
      Example.DeleteAll();
    }
  }
}
