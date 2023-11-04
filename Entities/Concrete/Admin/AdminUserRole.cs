using System;
namespace Entities.Concrete.Admin
{
	public class AdminUserRole
	{
        public int Id { get; set; }
        public required int AdminId { get; set; }
        public required int RoleId { get; set; }
    }
}

