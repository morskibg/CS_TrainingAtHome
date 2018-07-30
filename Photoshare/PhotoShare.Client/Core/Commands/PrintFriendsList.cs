using System;
using System.Text;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    public class PrintFriendsListCommand : ICommand
    {
        private readonly IUserService userService;

        public PrintFriendsListCommand(IUserService userService)
        {
            this.userService = userService;
        }
        public string Execute(string[] data)
        {
            var username = data[0];
            if (!this.userService.Exists(username))
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = this.userService.ByUsername<UserFriendsDto>(username);
            if (user.Friends.Count == 0)
            {
                return $"No friends for this user. :(";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Friends:");
            foreach (var friend in user.Friends)
            {
                sb.AppendLine($"-{friend.Username}");
            }
            return sb.ToString();
        }
    }
}
