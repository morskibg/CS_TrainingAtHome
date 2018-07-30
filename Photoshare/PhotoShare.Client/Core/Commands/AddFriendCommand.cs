using System.Linq;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Services.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Contracts;

    public class AddFriendCommand : ICommand
    {
        private readonly IUserService userService;

        public AddFriendCommand(IUserService userService)
        {
            this.userService = userService;
        }

        // AddFriend <username1> <username2>
        public string Execute(string[] data)
        {
            var usernameSender = data[0];
            var usernameReceiver = data[1];

            if (!this.userService.Exists(usernameSender))
            {
                throw new ArgumentException($"User {usernameSender} not found!");
            }

            if (!this.userService.Exists(usernameReceiver))
            {
                throw new ArgumentException($"User {usernameReceiver} not found!");
            }

            var sender = this.userService.ByUsername<UserFriendsDto>(usernameSender);

            var receiver = this.userService.ByUsername<UserFriendsDto>(usernameReceiver);

            bool isSentRequestFromUser = sender.Friends.Any(f => f.Username == receiver.Username);
            bool isSentRequestFromFriend = receiver.Friends.Any(f => f.Username == sender.Username);

            if (isSentRequestFromUser && isSentRequestFromFriend)
            {
                throw new InvalidOperationException($"{usernameReceiver} is already a friend to {usernameSender}");
            }
            else if (isSentRequestFromUser && !isSentRequestFromFriend)
            {
                throw new InvalidOperationException("Request is already sent!");
            }
            else if (!isSentRequestFromUser && isSentRequestFromFriend)
            {
                throw new InvalidOperationException("Request is already sent!");
            }

            this.userService.AddFriend(sender.Id, receiver.Id);

            return $"Friend {usernameReceiver} added to {usernameSender}";

            //if (receiver.Friends.Any(x => x.Username == sender.Username) 
            //    && sender.Friends.Any(x => x.Username == receiver.Username))
            //{
            //    throw new InvalidOperationException($"{receiver.Username} is already a friend to {sender.Username}");
            //}
            //if (receiver.Friends.Any(x => x.Username == sender.Username))
            //{
            //    throw new InvalidOperationException($"Friendship Request has been already sent !");
            //}

            //this.userService.AddFriend(sender.Id, receiver.Id);

            //return $"Friend {receiver.Username} added to {sender.Username}";
        }
    }
}
