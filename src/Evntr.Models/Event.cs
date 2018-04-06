﻿// Event.cs
// 
using System;
namespace Evntr.Models
{
	public class Event : BaseModel
	{
		public string Name { get; set; }
		public string Slogan { get; set; }
		public string Description { get; set; }
		public string LogoUrl { get; set; }
		public string When { get; set; }
		public string Where { get; set; }
		public string FullAddress { get; set; }
	}
}
