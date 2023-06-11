using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO;

public class ReviewsDTO
{
    public int Id { get; set; }
    public int Id_Accounts { get; set; }
    public int Id_Games { get; set; }
    public string? Review { get; set; }
}
