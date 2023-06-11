using GamesAppProiect.DataAccess.Data.Interface;

namespace GamesAppProiect.DataAccess.Factory
{
    public interface IFactory
    {
        IAccountsRepository AccountsRepository { get; }
        IGamesRepository GamesRepository { get; }
        IReviewsRepository ReviewsRepository { get; }
    }
}