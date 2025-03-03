using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TumeloStudyGroup.Models
{
	public class StudyGroupMember
	{
		[Key]
		public int StudentNumber { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Surname { get; set; }

		[Required, EmailAddress]
		public string Email { get; set; }
	}
}