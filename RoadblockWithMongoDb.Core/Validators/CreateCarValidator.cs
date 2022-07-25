﻿using FluentValidation;
using RoadblockWithMongoDb.Contracts.Constants;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;

namespace RoadblockWithMongoDb.Core.Validators
{
    public class CreateCarValidator : AbstractValidator<CreateCarDTO>
    {
        public CreateCarValidator()
        {
            RuleFor(x => x.VehicleNumber).NotEmpty().NotNull().WithMessage("Car vehicle number is required");

            RuleFor(x => x.Persons).NotEmpty().NotNull().WithMessage("Car must be have a driver");

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.Surname).NotEmpty().NotNull());

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.Name).NotEmpty().NotNull());

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.Age).NotEmpty().NotNull());

            RuleForEach(x => x.Persons).ChildRules(x => x.RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Matches(RegexTemplates.UrkainianPhoneNumber));
        }
    }
}
