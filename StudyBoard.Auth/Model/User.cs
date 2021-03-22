using System.Collections.Generic;
using StudyBoard.Core.Model.Base;
using StudyBoard.Core.Model.Enum;

namespace StudyBoard.Auth.Model
{
	public class User : BaseObject {
		public string Login { get; set; }
		public string Password { get; set; }
		public IList<UserRole> Roles { get; set; }
	}
}
