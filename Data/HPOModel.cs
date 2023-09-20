using System;
using System.ComponentModel.DataAnnotations;

public class Class1
{
	public Class1()
	{
		public int ID {  get; set; }
		[Required]
		[Display(Name ="HPO Term")]
		public string Term { get; set; }
		[Required]
		[Display(Name = "HPO ID")]
		public string HPOID { get; set; }

	}
}
