using System;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Utilities;
using PhotoShare.Services.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTagCommand : ICommand
    {
        private readonly ITagService tagService;

        public AddTagCommand(ITagService tagService)
        {
            this.tagService = tagService;
        }

        public string Execute(string[] data)
        {
            string tag = data[0];
            tag = tag.ValidateOrTransform();
            if (tagService.Exists(tag))
            {
                throw new ArgumentException($"Tag {tag} exists!");
            }
            tagService.AddTag(tag);
            return $"Tag {tag} was added successfully!";
        }
    }
}