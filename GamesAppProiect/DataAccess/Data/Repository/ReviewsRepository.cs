using GamesAppProiect.DataAccess.Data.Interface;
using GamesAppProiect.Models;
using ProiectPractica.DataAccess.Connection;

namespace GamesAppProiect.DataAccess.Data.Repository;

public class ReviewsRepository : Repository<Reviews>, IReviewsRepository
{
    protected ISqlDataAccess sqlDataAccess;

    public ReviewsRepository(ISqlDataAccess sqlDataAcess) : base(sqlDataAcess)
    {

    }
}
