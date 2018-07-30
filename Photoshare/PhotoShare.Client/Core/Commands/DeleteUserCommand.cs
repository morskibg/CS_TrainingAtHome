namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Dtos;
    using Contracts;
    using Services.Contracts;

    public class DeleteUserCommand : ICommand
    {
        private readonly IUserService userService;

        public DeleteUserCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // DeleteUserCommand <username>
        public string Execute(string[] data)
        {
            string username = data[1];

            var userExists = this.userService.Exists(username);

            if (!userExists)
            {
                throw new ArgumentException($"User {username} not found!");
            }
            if (this.userService.ByUsername<UserDto>(username).IsDeleted == true )
            {
                throw new ArgumentException($"User {username} is already deleted!");
            }
           
            this.userService.Delete(username);

            return $"User {username} was deleted successfully!";
        }
    }
}
