using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Validators.ValidatorsModels;

public class ReviewsValidator : Validator<ReviewsDTO>, IValidator<ReviewsDTO>
{
    public ReviewsValidator() : base() { }
    public override void Validate(ReviewsDTO value)
    {
        if (string.IsNullOrEmpty(value.Review))
            Errors.Add("Review null"); 
    }
}
