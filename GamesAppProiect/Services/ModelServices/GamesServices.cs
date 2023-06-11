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

public class GamesServices : IGamesServices
{
    private readonly IFactory _factory;
    private readonly IValidator<GamesDTO> validator;

    public GamesServices(IFactory _factory, IValidator<GamesDTO> validator)
    {
        this._factory = _factory;
        this.validator = validator;
    }

    public async Task<bool> DeleteAsync(GamesDTO value)
    {
        var game = new Games() { Id = value.Id };
        return await this._factory.GamesRepository.DeleteAsync(game);
    }

    public async Task<List<GamesDTO>> GetAllAsync()
    {
        var games = await this._factory.GamesRepository.GetAllAsync();
        return ManualMappers.Map(games);
    }

    public async Task<GamesDTO> InsertAsync(GamesDTO value)
    {
        var existendGame = await this._factory.GamesRepository.FirstOrDefaultAsync(x => x.GameName == value.GameName);

        if (existendGame != null)
        {
            throw new Exception("The game it's already existent");
        }

        this.validator.Validate(value);

        if (this.validator.Errors.Any())
        {
            throw new Exception(this.validator.GetErrors());
        }

        var game = ManualMappers.Map(value);

        var gameDTO = await this._factory.GamesRepository.InsertAsync(game);

        if (gameDTO != null)
        {
            return ManualMappers.Map(gameDTO);
        }

        throw new Exception("Error at insert");
    }

    public async Task<GamesDTO> UpdateAsync(GamesDTO value)
    {
        var existendGame = await this._factory.GamesRepository.FirstOrDefaultAsync(x => x.Id == value.Id);

        if (existendGame == null)
        {
            throw new Exception("Incorrect game");
        }

        this.validator.Validate(value);

        if (this.validator.Errors.Any())
        {
            throw new Exception(this.validator.GetErrors());
        }

        var game = ManualMappers.Map(value);

        var gameDTO = await this._factory.GamesRepository.UpdateAsync(game);

        if (gameDTO != null)
        {
            return ManualMappers.Map(gameDTO);
        }

        throw new Exception("Error at update");
    }
}
