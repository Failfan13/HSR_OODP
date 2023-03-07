using System;
using System.Data.SQLite;

class DataClass
{
    private string _databaseConnection = "Data Source=TestBase.db; Version = 3;";
    private SQLiteConnection? _conn;
    private SQLiteCommand? SQLcmd;

    public DataClass()
    {
        try
        {
            Conn.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public SQLiteConnection Conn
    {
        get => new SQLiteConnection(_databaseConnection);
        set => _conn = value;
    }

    public void CreateTable()
    {
        SQLcmd = Conn.CreateCommand();
        Console.WriteLine(Conn.State);
        // SQLcmd.CommandText = "CREATE TABLE SampleTable(Col1 VARCHAR(20), Col2 INT)";
        // SQLcmd.ExecuteNonQuery();
    }

    public void CreateTable(string query)
    {

    }
}