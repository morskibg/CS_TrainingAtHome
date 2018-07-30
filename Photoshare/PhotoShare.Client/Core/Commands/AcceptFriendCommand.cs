using System.Linq;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    using System;
    using Contracts;

    public class AcceptFriendCommand : ICommand
    {
        private readonly IUserService userService;
        public AcceptFriendCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // AcceptFriend <username1> <username2>
        //[username1] accepted [username2] as a friend
        public string Execute(string[] data)
        {
            //var usernameAccepter = data[0];
            //var usernameSender = data[1];

            //if (!this.userService.Exists(usernameAccepter))
            //{
            //    throw new ArgumentException($"{usernameAccepter} not found!");
            //}

            //if (!this.userService.Exists(usernameSender))
            //{
            //    throw new ArgumentException($"{usernameSender} not found!");
            //}

            //var accepter = this.userService.ByUsername<UserFriendsDto>(usernameAccepter);

            //var sender = this.userService.ByUsername<UserFriendsDto>(usernameSender);

            //if (sender.Friends.Any(x => x.Username == accepter.Username)
            //    && accepter.Friends.Any(x => x.Username == sender.Username))
            //{
            //    throw new InvalidOperationException($"{sender.Username} is already a friend to {accepter.Username}");
            //}
            //if (sender.Friends.All(x => x.Username != accepter.Username))
            //{
            //    throw new InvalidOperationException($"{sender.Username} has not added {accepter.Username} as a friend");
            //}
            //if (accepter.Friends.Any(x => x.Username == sender.Username))
            //{
            //    throw new InvalidOperationException($"bla bla");
            //}
            //this.userService.AcceptFriend(accepter.Id, sender.Id);
            //this.userService.AcceptFriend(sender.Id, accepter.Id);

            //return $"{accepter.Username} accepted {sender.Username} as a friend";
            if (data.Length != 2)
            {
                int commandNameLenght = this.GetType().Name.Length - "Command".Length;
                string commandName = this.GetType().Name.Substring(0, commandNameLenght);

                throw new ArgumentException($"Command {commandName} not valid");
            }

            string username = data[0];
            string friendUsername = data[1];

            if (!this.userService.Exists(username))
            {
                throw new ArgumentException($"User{username} not found!");
            }

            if (!this.userService.Exists(friendUsername))
            {
                throw new ArgumentException($"User {friendUsername} not found!");
            }

            UserFriendsDto user = this.userService.ByUsername<UserFriendsDto>(username);
            UserFriendsDto friend = this.userService.ByUsername<UserFriendsDto>(friendUsername);

            bool isSentRequestFromUser = user.Friends.Any(f => f.Username == friend.Username);
            bool isSentRequestFromFriend = friend.Friends.Any(f => f.Username == user.Username);

            if (isSentRequestFromFriend && isSentRequestFromUser)
            {
                throw new InvalidOperationException($"{friendUsername} is already a friend to {username}");
            }

            if (!isSentRequestFromFriend)
            {
                throw new InvalidOperationException($"{friendUsername} has not added {username} as a friend");
            }

            this.userService.AcceptFriend(user.Id, friend.Id);

            return $"{username} accepted {friendUsername} as a friend";
        }
    }
}
