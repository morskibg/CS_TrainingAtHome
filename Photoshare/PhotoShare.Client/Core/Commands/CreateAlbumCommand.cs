using System.Linq;
using PhotoShare.Client.Core.Dtos;
using PhotoShare.Client.Utilities;
using PhotoShare.Models.Enums;

namespace PhotoShare.Client.Core.Commands
{
    using System;
    using Contracts;
    using Services.Contracts;


    public class CreateAlbumCommand : ICommand
    {
        private readonly IAlbumService albumService;
        private readonly IUserService userService;
        private readonly ITagService tagService;

        public CreateAlbumCommand(IAlbumService albumService, IUserService userService, ITagService tagService)
        {
            this.albumService = albumService;
            this.userService = userService;
            this.tagService = tagService;
        }

        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(string[] data)
        {
            string username = data[0];
            string albumName = data[1];
            //Color backgroundColor;
            var isValidColor = Enum.TryParse(data[2], out Color backgroundColor);
            var tags = data.Skip(3).ToArray();

            if (!this.userService.Exists(username))
            {
                throw new ArgumentException($"User {username} not found!");
            }
            if (this.albumService.Exists(albumName))
            {
                throw new ArgumentException($"Album {albumName} exists!");
            }
            if (!isValidColor)
            {
                throw new ArgumentException($"Color {data[2]} not found!");
            }
            //tags.ForEach(x => x.ValidateOrTransform());
            foreach (var tag in tags.Select(x => x.ValidateOrTransform()))
            {
                if (!this.tagService.Exists(tag))
                {
                    throw new ArgumentException("Invalid tags!");
                }
            }
            int userId = this.userService.ByUsername<UserDto>(username).Id;

            this.albumService.Create(userId, albumName, backgroundColor.ToString(), tags);
            return $"Album {albumName} successfully created!";
        }
    }
}