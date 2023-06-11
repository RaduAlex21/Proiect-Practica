namespace ProiectPractica.DataAccess.Connection;

public class SqlDataAccess : ISqlDataAccess
{
    public string Connection { get; private set; }
    public SqlDataAccess(string connection)
    {
        this.Connection = connection;
    }
}
