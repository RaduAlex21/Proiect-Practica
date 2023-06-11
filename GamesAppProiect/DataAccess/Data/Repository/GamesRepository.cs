using GamesAppProiect.DataAccess.Data.Interface;
using GamesAppProiect.Models;
using ProiectPractica.DataAccess.Connection;

namespace GamesAppProiect.DataAccess.Data.Repository;

public class GamesRepository : Repository<Games>, IGamesRepository
{
    protected ISqlDataAccess sqlDataAccess;

    public GamesRepository(ISqlDataAccess sqlDataAcess) : base(sqlDataAcess)
    {

    }
}
