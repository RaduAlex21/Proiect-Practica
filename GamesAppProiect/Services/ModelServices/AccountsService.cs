using DTO;
using GamesAppProiect.DataAccess.Factory;
using GamesAppProiect.Models;
using Mappers;
using Services.ModelServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validators;

namespace Services.ModelServices;

public class AccountsService : IAccountsService
{
    private readonly IFactory factory;
    private readonly IValidator<AccountsDTO> validator;

    public AccountsService(IFactory factory, IValidator<AccountsDTO> validator)
    {
        this.factory = factory;
        this.validator = validator;
    }

    public async Task<bool> DeleteAsync(AccountsDTO value)
    {
        var account = new Accounts() { Id = value.Id };
        return await this.factory.AccountsRepository.DeleteAsync(account);
    }

    public async Task<List<AccountsDTO>> GetAllAsync()
    {
        var accounts = await this.factory.AccountsRepository.GetAllAsync();
        return ManualMappers.Map(accounts);
    }

    public async Task<AccountsDTO> InsertAsync(AccountsDTO value)
    {
        var existentAccount = await this.factory.AccountsRepository.FirstOrDefaultAsync(x => x.Username == value.Username ||
                                                                                      x.Email == value.Email ||
                                                                                      x.Phone == value.Phone);
        if (existentAccount != null)
        {
            throw new Exception("Username or Email or PhoneNumber exist");
        }

        this.validator.Validate(value);

        if (this.validator.Errors.Any())
        {
            throw new Exception(this.validator.GetErrors());
        }

        var account = ManualMappers.Map(value);

        var accountDTO = await this.factory.AccountsRepository.InsertAsync(account);

        if (accountDTO != null)
        {
            return ManualMappers.Map(accountDTO);
        }

        throw new Exception("Error at insert");
    }

    public async Task<AccountsDTO> UpdateAsync(AccountsDTO value)
    {
        var existentAccount = await this.factory.AccountsRepository.FirstOrDefaultAsync(x => x.Id == value.Id);
         
        if (existentAccount == null)
        {
            throw new Exception("Incorrect account");
        }

        this.validator.Validate(value);

        if (this.validator.Errors.Any())
        {
            throw new Exception(this.validator.GetErrors());
        }

        var account = ManualMappers.Map(value);

        var accountDTO = await this.factory.AccountsRepository.UpdateAsync(account);

        if (accountDTO != null)
        {
            return ManualMappers.Map(accountDTO);
        }

        throw new Exception("Error at update");

    }

    public async Task<AccountsDTO> GetAccount(string username)
    {
        var account = await this.factory.AccountsRepository.FirstOrDefaultAsync(x => x.Username == username);

        if (account == null)
        {
            throw new Exception("It's aleary an account with that username");
        }

        return ManualMappers.Map(account);
    }

    public async Task<AccountsDTO> SearchByIdAsync(int id)
    {
        var account = await this.factory.AccountsRepository.FirstOrDefaultAsync(x => x.Id == id);

        if (account == null)
            throw new Exception("Account null");

        return ManualMappers.Map(account);
    }
}
