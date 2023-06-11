using Dapper.Contrib.Extensions;
using ProiectPractica.DataAccess.Connection;
using System.Numerics;
using Utils;

namespace GamesAppProiect.Models;

[Table("tAccounts")]

public class Accounts
{
    [Key]
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public Role Role { get; set; }
}
