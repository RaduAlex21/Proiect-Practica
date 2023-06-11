using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelServices.Contracts;

public interface IAccountsService : IService<AccountsDTO>
{
    Task<AccountsDTO> GetAccount(string username);
}
