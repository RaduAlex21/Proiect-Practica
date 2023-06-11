using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Validators.ValidatorsModels;

public class GamesValidator : Validator<GamesDTO>, IValidator<GamesDTO> 
{
    public GamesValidator() : base() { }
    public override void Validate(GamesDTO value)
    {
        if (string.IsNullOrEmpty(value.GameName))
            Errors.Add("GameName null");

        if (string.IsNullOrEmpty(value.GameDescription))
            Errors.Add("GameDescription null");

        if (string.IsNullOrEmpty(value.Price))
            Errors.Add("Price null");

        if (string.IsNullOrEmpty(value.RealeseDate))
            Errors.Add("RealeseDate null");
    }
}
