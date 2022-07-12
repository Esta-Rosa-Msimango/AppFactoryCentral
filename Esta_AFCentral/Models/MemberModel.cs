using System;
using System.ComponentModel.DataAnnotations;
using DataAccess;

namespace Esta_AFCentral.Models
{
	public class MemberModel //access test private
	{
		private int _MemberId;
		private string _FirstName;
		private string _LastName;
		private string _Position;
		private string _Email;
		private string _Phone;
		private string _ProgrammeName;

        public MemberModel()
        {
        }

        public MemberModel(int memberId, string firstName, string lastName, string position, string email, string phone, string programmeName)
        {
			this._MemberId = memberId;
            this._FirstName = firstName;
            this._LastName = lastName;
            this._Position = position;
            this._Email = email;
            this._Phone = phone;
            this._ProgrammeName = programmeName;
        }

		public int MemberId
        {
            get { return _MemberId; }
        }

		public string FirstName { 
			get { return _FirstName; } 
			set { _FirstName = value; }
		}
		public string LastName { 
			get { return _LastName; }
            set { _LastName = value;  }
		}
		public string FullName
		{
			get { return FirstName + " " + LastName; }
		}
		public string Position {
            get { return _Position; } 
			set { _Position = value; } 
		}
		public string Email { 
			get { return _Email; }
			set { _Email = value; }
		}
		public string Phone { 
			get { return _Phone; }
			set { _Phone = value; }
		}
		public string ProgrammeName { 
			get { return _ProgrammeName; }
			set { _ProgrammeName = value; }
		}
	}
}