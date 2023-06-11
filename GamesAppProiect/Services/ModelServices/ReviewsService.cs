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

public class ReviewsService : IReviewsService
{
    private readonly IFactory _factory;
    private readonly IValidator<ReviewsDTO> validator;

    public ReviewsService(IFactory _factory, IValidator<ReviewsDTO> validator)
    {
        this._factory = _factory;
        this.validator = validator;
    }

    public async Task<bool> DeleteAsync(ReviewsDTO value)
    {
        var review = new Reviews() { Id = value.Id };
        return await this._factory.ReviewsRepository.DeleteAsync(review);
    }

    public async Task<List<ReviewsDTO>> GetAllAsync()
    {
        var review = await this._factory.ReviewsRepository.GetAllAsync();
        return ManualMappers.Map(review);
    }

    public async Task<ReviewsDTO> InsertAsync(ReviewsDTO value)
    {
        var existendReview = await this._factory.ReviewsRepository.FirstOrDefaultAsync(x => x.Id == value.Id);

        if (existendReview != null)
        {
            throw new Exception("You already have a review at this game");
        }

        this.validator.Validate(value);

        if (this.validator.Errors.Any())
        {
            throw new Exception(this.validator.GetErrors());
        }

        var review = ManualMappers.Map(value);

        var reviewDTO = await this._factory.ReviewsRepository.InsertAsync(review);

        if (reviewDTO != null)
        {
            return ManualMappers.Map(reviewDTO);
        }

        throw new Exception("Error at insert");
    }

    public async Task<ReviewsDTO> UpdateAsync(ReviewsDTO value)
    {
        var existendReview = await this._factory.ReviewsRepository.FirstOrDefaultAsync(x => x.Id == value.Id);

        if (existendReview == null)
        {
            throw new Exception("Incorrect review");
        }

        this.validator.Validate(value);

        if (this.validator.Errors.Any())
        {
            throw new Exception(this.validator.GetErrors());
        }

        var review = ManualMappers.Map(value);

        var reviewDTO = await this._factory.ReviewsRepository.UpdateAsync(review);

        if (reviewDTO != null)
        {
            return ManualMappers.Map(reviewDTO);
        }

        throw new Exception("Error at update");
    }
}
