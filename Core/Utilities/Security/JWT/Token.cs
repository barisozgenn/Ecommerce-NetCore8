using System;
namespace Core.Utilities.Security.JWT
{
    public class Token
    {   // define our token model
        public string? AccesToken { get; set; }
        public DateTime DateExpire { get; set; }
        public string? RefreshToken { get; set; }
    }
}

