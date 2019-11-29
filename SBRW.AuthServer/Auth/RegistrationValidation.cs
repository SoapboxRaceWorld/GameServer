// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/28/2019 @ 12:06 PM.

using FluentValidation;

namespace SBRW.AuthServer.Auth
{
    public class RegistrationValidation : AbstractValidator<RegistrationModel>
    {
        public RegistrationValidation()
        {
            RuleFor(vm => vm.Email).NotEmpty().WithMessage("Email cannot be empty").EmailAddress()
                .WithMessage("Email must be valid");
            RuleFor(vm => vm.Password).NotEmpty().WithMessage("Password cannot be empty");
        }
    }
}