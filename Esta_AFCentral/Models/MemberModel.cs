using System;
using System.ComponentModel.DataAnnotations;
using DataAccess;

namespace Esta_AFCentral.Models
{
	public class MemberModel
	{
		[Key]
		public int MemberId { get; private set; }
		[Required]
        [StringLength(50)]
		public string FirstName { get; set; }
		[StringLength(50)]
		public string LastName { get; set; }
		public string FullName
		{
			get { return FirstName + " " + LastName; }
		}
		[Required]
		[StringLength(50)]
		public string Position { get; set; }
		[Required]
		[EmailAddress]
		[StringLength(50)]
		public string Email { get; set; }
        [Phone]
        [StringLength(50)]
		public string Phone { get; set; }
		public string Name { get; set; }
	}
}

 