using DTO;
using GamesAppProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers;

public class ManualMappers
{
    #region Accounts
    public static AccountsDTO Map(Accounts value)
    {
        AccountsDTO result = new AccountsDTO();
        result.Id = value.Id;
        result.Username = value.Username;
        result.Password = value.Password;
        result.Email = value.Email;
        result.Phone = value.Phone;
        result.Role = value.Role;

        return result;
    }

    public static Accounts Map(AccountsDTO value)
    {
        Accounts result = new Accounts();
        result.Id = value.Id;
        result.Username = value.Username;
        result.Password = value.Password; 
        result.Email = value.Email;
        result.Phone = value.Phone;
        result.Role = value.Role;

        return result;
    }

    public static List<AccountsDTO> Map(List<Accounts> accounts)
    {
        return accounts.Select(account => Map(account)).ToList();
    }
    #endregion

    #region Games
    public static GamesDTO Map(Games value)
    {
        GamesDTO result = new GamesDTO();
        result.Id = value.Id;
        result.GameName = value.GameName;
        result.GameDescription = value.GameDescription;
        result.Price = value.Price;
        result.RealeseDate = value.RealeseDate;
         
        return result;
    }

    public static Games Map(GamesDTO value)
    {
        Games result = new Games();
        result.Id = value.Id;
        result.GameName = value.GameName;
        result.GameDescription = value.GameDescription;
        result.Price = value.Price;
        result.RealeseDate = value.RealeseDate;

        return result;
    }

    public static List<GamesDTO> Map(List<Games> games)
    {
        return games.Select(game => Map(game)).ToList();
    }
    #endregion

    #region Reviews
    public static ReviewsDTO Map(Reviews value)
    {
        ReviewsDTO result = new ReviewsDTO();
        result.Id = value.Id;
        result.Id_Accounts = value.Id_Accounts;
        result.Id_Games = value.Id_Games;
        result.Review = value.Review; 

        return result;
    }

    public static Reviews Map(ReviewsDTO value)
    {
        Reviews result = new Reviews();
        result.Id = value.Id;
        result.Id_Accounts = value.Id_Accounts;
        result.Id_Games = value.Id_Games;
        result.Review = value.Review;

        return result;
    }

    public static List<ReviewsDTO> Map(List<Reviews> reviews)
    {
        return reviews.Select(review => Map(review)).ToList();
    }
    #endregion
}
