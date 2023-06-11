using GamesAppProiect.DataAccess.Data.Interface;
using GamesAppProiect.DataAccess.Data.Repository;
using ProiectPractica.DataAccess.Connection;

namespace GamesAppProiect.DataAccess.Factory;

public class Factory : IFactory
{
    private readonly ISqlDataAccess _sqlDataAccess;

    public IAccountsRepository AccountsRepository => new AccountsRepository(_sqlDataAccess);
    public IGamesRepository GamesRepository => new GamesRepository(_sqlDataAccess);
    public IReviewsRepository ReviewsRepository => new ReviewsRepository(_sqlDataAccess);

    public Factory(ISqlDataAccess sqlDataAccess)
    {
        _sqlDataAccess = sqlDataAccess;
    }
}
