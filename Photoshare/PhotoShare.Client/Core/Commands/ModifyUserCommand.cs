using System.Linq;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    using System;
    using Contracts;

    public class ModifyUserCommand : ICommand
    {
        private readonly IUserService userService;
        private readonly ITownService townService;
        public ModifyUserCommand(IUserService userService, ITownService townService)
        {
            this.userService = userService;
            this.townService = townService;
        }

        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public string Execute(string[] data)
        {
            string username = data[0];
            string property = data[1];
            string newValue = data[2];

            if (!this.userService.Exists(username))
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var userId = this.userService.ByUsername<UserDto>(username).Id;

            if (property == "Password")
            {
                bool hasLowerLetter = newValue.Any(char.IsLower);
                bool hasDigit = newValue.Any(char.IsDigit);
                if (!hasDigit || !hasLowerLetter)
                {
                    throw new ArgumentException($"Value {newValue} not valid!" +
                                                $"{Environment.NewLine}InvalidPassword");
                }
                this.userService.ChangePassword(userId, newValue);
            }
            //else if (property == "BornTown")
            //{
            //    if (!this.townService.Exists(newValue))
            //    {
            //        throw new ArgumentException($"Value {newValue} not valid!" +
            //                                    $"{Environment.NewLine}Town {newValue} not found!");
                    
            //    }
            //    int townId = this.townService.ByName<TownDto>(newValue).Id;
            //    this.userService.SetBornTown(userId, townId);
            //}
            //else if (property == "CurrentTown")
            //{
            //    if (!this.townService.Exists(newValue))
            //    {
            //        throw new ArgumentException($"Value {newValue} not valid!" +
            //                                    $"{Environment.NewLine}Town {newValue} not found!");
            //    }
            //    int townId = this.townService.ByName<TownDto>(newValue).Id;
            //    this.userService.SetCurrentTown(userId, townId);
            //}
            else if (property == "CurrentTown" || property == "BornTown")
            {
                if (!this.townService.Exists(newValue))
                {
                    throw new ArgumentException($"Value {newValue} not valid!" +
                                                $"{Environment.NewLine}Town {newValue} not found!");
                }
                int townId = this.townService.ByName<TownDto>(newValue).Id;
                if (property == "CurrentTown")
                {
                    this.userService.SetCurrentTown(userId, townId);
                }
                else
                {
                    this.userService.SetBornTown(userId, townId);
                }  
            }
            else
            {
                throw new ArgumentException($"Property {property} not supported!");
            }

            return $"User {username} {property} is {newValue}.";
        }
    }
}
