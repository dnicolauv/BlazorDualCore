using System;

namespace BlazorDualCore.Shared
{
    public class Person
    {
        private string avatarUrl;

        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public string AvatarUrl { get => avatarUrl.Replace("&amp;", "&"); set => avatarUrl = value; }
    }
}
