using GamesAppProiect.DataAccess.Data.Interface;
using GamesAppProiect.Models;
using ProiectPractica.DataAccess.Connection;

namespace GamesAppProiect.DataAccess.Data.Repository;

public sealed class AccountsRepository : Repository<Accounts>, IAccountsRepository
{
    protected ISqlDataAccess sqlDataAccess;

    public AccountsRepository(ISqlDataAccess sqlDataAcess) : base(sqlDataAcess)
    {
         
    }
}
