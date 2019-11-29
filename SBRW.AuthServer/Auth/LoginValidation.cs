using FluentValidation;

namespace SBRW.GameServer.Auth
{
    public class LoginValidation : AbstractValidator<LoginModel>
    {
        public LoginValidation()
        {
            RuleFor(vm => vm.Email).NotEmpty().WithMessage("Email must not be empty").EmailAddress()
                .WithMessage("Email must be valid");
            RuleFor(vm => vm.Password).NotEmpty().WithMessage("Password must not be empty");
        }
    }
}