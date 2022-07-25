using FluentValidation;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;
using System;

namespace RoadblockWithMongoDb.Core.Validators
{
    public class EditCarValidator : AbstractValidator<EditCarDTO>
    {
        public EditCarValidator()
        {
            RuleFor(x => x.VehicleNumber).NotEmpty().NotNull().WithMessage("Car vehicle number is required");

            RuleFor(x => x.Persons).NotEmpty().NotNull().WithMessage("Car must be have a driver");

            RuleFor(x => x.AddedOn).NotEmpty().NotNull().LessThanOrEqualTo(DateTime.UtcNow);

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.Surname).NotEmpty().NotNull());

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.Name).NotEmpty().NotNull());

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.Age).NotEmpty().NotNull());

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Matches(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"));
        }
    }
}
