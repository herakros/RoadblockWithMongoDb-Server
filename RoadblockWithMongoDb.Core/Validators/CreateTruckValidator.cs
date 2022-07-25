﻿using FluentValidation;
using RoadblockWithMongoDb.Contracts.DTO.TruckDTO;

namespace RoadblockWithMongoDb.Core.Validators
{
    public class CreateTruckValidator : AbstractValidator<CreateTruckDTO>
    {
        public CreateTruckValidator()
        {
            RuleFor(x => x.Model).NotEmpty().NotNull();

            RuleFor(x => x.TruckWeight).NotEmpty().NotNull();

            RuleFor(x => x.VehicleNumber).NotEmpty().NotNull().WithMessage("Truck vehicle number is required");

            RuleFor(x => x.Driver).NotEmpty().NotNull().WithMessage("Truck must be have a driver");

            RuleFor(x => x.Driver).ChildRules(x => x.RuleFor(x => x.Surname).NotEmpty().NotNull());

            RuleFor(x => x.Driver).ChildRules(x => x.RuleFor(x => x.Name).NotEmpty().NotNull());

            RuleFor(x => x.Driver).ChildRules(x => x.RuleFor(x => x.Age).NotEmpty().NotNull());

            RuleFor(x => x.Driver).ChildRules(x => x.RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Matches(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"));
        }
    }
}