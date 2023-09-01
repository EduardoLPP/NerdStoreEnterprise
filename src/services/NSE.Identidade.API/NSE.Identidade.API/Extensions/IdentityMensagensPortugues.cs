using Microsoft.AspNetCore.Identity;

namespace NSE.Identidade.API.Extensions
{
    public class IdentityMensagensPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
        { 
            return new IdentityError { 
                    Code = nameof(DefaultError),
                    Description  = $"Ocorreu um erro desconhecido." 
            };
        }
        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = $"Falha de concorrência otimista. O objeto foi modificado."
            };
        }
        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = $"Senha incorreta."
            };
        }
        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = $"Token inválido."
            };
        }
        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = $"Já existe um usuário com esse login."
            };
        }
        public override IdentityError InvalidUserName(string username)
        {
            return new IdentityError
            {
                Code = nameof(InvalidUserName),
                Description = $"O login '{username}' é invalido, pode conter apenas letras e digitos."
            };
        }
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(InvalidEmail),
                Description = $"O email '{email}' é invalido."
            };
        }
        public override IdentityError DuplicateUserName(string username)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = $"O login '{username}' já está sendo utilizado."
            };
        }
        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(InvalidRoleName),
                Description = $"A permissão '{role}' é inválida."
            };
        }
        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateRoleName),
                Description = $"A permissão '{role}' já está sendo utilizado."
            };
        }
        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = $"O usuário já possui uma senha definida."
            };
        }
        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = nameof(UserLockoutNotEnabled),
                Description = $"O lockout não está habilitado para esse usuário."
            };
        }
        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyInRole),
                Description = $"O usuário já possui a permissão '{role}'."
            };
        }
        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserNotInRole),
                Description = $"O usuário não possui a permissão '{role}'."
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = $"As senhas devem conter no mínimo '{length}' caracteres."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = $"As senhas devem conter ao menos um caractere."
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = $"As senhas devem conter ao menos um dígito entre 0 a 9."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = $"As senhas devem conter ao menos uma letra minúscula."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = $"As senhas devem conter ao menos uma letra maiúscula."
            };
        }
    }
}
