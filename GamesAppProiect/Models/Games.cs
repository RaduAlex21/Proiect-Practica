using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Utils;

namespace GamesAppProiect.Models;

[Table("tGames")]

public class Games
{
    [Key]
    public int Id { get; set; }
    public string? GameName { get; set; }
    public string? GameDescription { get; set; }
    public string? Price { get; set; }
    public string? RealeseDate { get; set; }
}
