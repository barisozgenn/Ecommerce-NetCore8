using System;
namespace Entities.Concrete.Admin
{
	public class AdminUserRole
	{
        public int Id { get; set; }
        public int AdminId { get; set; }
        public int RoleId { get; set; }
    }
}

