using System;
namespace Entities.Concrete.Admin
{
	public class AdminEmailParameter
	{
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }

        public required string Smtp { get; set; }
        public int Port { get; set; }

        public bool SSL { get; set; }//db de bit
        public bool Html { get; set; }//db de bit
    }
}

