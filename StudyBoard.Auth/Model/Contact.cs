using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyBoard.Core.Model.Base;

namespace StudyBoard.Auth.Model {
	public class Contact : BaseObject {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}
}