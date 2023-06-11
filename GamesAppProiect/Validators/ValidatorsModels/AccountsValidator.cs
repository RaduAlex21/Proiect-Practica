using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validators.ValidatorsModels;

public class AccountsValidator : Validator<AccountsDTO>, IValidator<AccountsDTO>
{
    public AccountsValidator() : base() { }
    public override void Validate(AccountsDTO value)
    {
        if (string.IsNullOrEmpty(value.Username))
            Errors.Add("Username null");

        if (string.IsNullOrEmpty(value.Password))
            Errors.Add("Password null");

        if (string.IsNullOrEmpty(value.Email))
            Errors.Add("Email null");

        if (string.IsNullOrEmpty(value.Phone))
            Errors.Add("Phone null");
    }
}
