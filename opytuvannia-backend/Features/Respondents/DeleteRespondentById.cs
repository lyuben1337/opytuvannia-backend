using Carter;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using opytuvannia_backend.Database;
using opytuvannia_backend.Shared;

namespace opytuvannia_backend.Features.Respondents;

public static class DeleteRespondentById
{
    public class Command : IRequest<Result>
    {
        public required string Id { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(c => c.Id)
                .Must(id => Guid.TryParse(id, out _))
                .WithMessage("Invalid id format");
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Result>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IValidator<Command> _validator;

        public Handler(ApplicationDbContext dbContext, IValidator<Command> validator)
        {
            _dbContext = dbContext;
            _validator = validator;
        }

        public async Task<Result> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return Result.Failure(new Error("DeleteRespondent.Validation", validationResult.ToString()));
            }

            var respondent = await _dbContext.Respondents.FindAsync(request.Id, cancellationToken);

            if (respondent is null)
            {
                return Result.Failure(Error.RespondentNotFound);
            }

            _dbContext.Remove(respondent);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Result.Success();
        }
    }
}

public class DeleteRespondentEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapDelete("api/v1/respondents/{id}", Handler);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Error))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Error))]
    private async Task<IResult> Handler(string id, ISender sender)
    {
        var command = new DeleteRespondentById.Command
        {
            Id = id
        };

        var result = await sender.Send(command);

        if (result.IsSuccess)
        {
            return Results.NoContent();
        }

        if (result.Error.Equals(Error.RespondentNotFound))
        {
            return Results.NotFound(result.Error);
        }

        return Results.BadRequest(result.Error);
    }
}