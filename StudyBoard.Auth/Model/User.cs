using System.Collections.Generic;
using StudyBoard.Core.Model;
using StudyBoard.Core.Model.Base;

namespace StudyBoard.Auth.Model
{
	public class User : BaseObject {
		public string Login { get; set; }
		public string Password { get; set; }
		public IList<UserRole> Roles { get; set; }
	}
}
