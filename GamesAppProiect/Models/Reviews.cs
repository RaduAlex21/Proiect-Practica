using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace GamesAppProiect.Models;


[Table("tReviews")]

public class Reviews
{
    [Key]
    public int Id { get; set; }
    public int Id_Accounts { get; set; }
    public int Id_Games { get; set; }
    public string? Review { get; set; }
}