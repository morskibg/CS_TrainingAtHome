using PhotoShare.Client.Core.Dtos;
using PhotoShare.Models;
using PhotoShare.Services.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Contracts;

    public class RegisterUserCommand : ICommand
    {
        private readonly IUserService userService;

        public RegisterUserCommand(IUserService userService)
        {
            this.userService = userService;
        }

      

        // RegisterUser <username> <password> <repeat-password> <email>
        public string Execute(string[] data)
        {
            const int argumentsCount = 4;
            if (data.Length != argumentsCount)
            {
                throw new InvalidOperationException($"Command RegisterUser not valid");
            }
            var username = data[0];
            var password = data[1];
            var repeatedPassword = data[2];
            var email = data[3];

            RegisterUserDto userDto = new RegisterUserDto
            {
                Username = username,
                Password = password,
                RepeatPassword = repeatedPassword,
                Email = email
            };
            if (!IsValid(userDto))
            {
                throw new ArgumentException("Invalid input data for user registration !");
            }
            if (password != repeatedPassword)
            {
                throw new ArgumentException("Passwords do not match!");
            }
            if (this.userService.ByUsername<User>(username) != null)
            {
                throw new InvalidOperationException($"Username {username} is already taken!");
            }
            this.userService.Register(username, password, email);
            return $"User {username} was registered successfully!";
        }

        private bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }
    }
}
