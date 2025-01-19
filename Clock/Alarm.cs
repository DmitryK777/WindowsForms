﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	internal class Alarm
	{
		public DateTime Date {  get; set; }
		public TimeSpan Time { get; set; }
		public DayOfWeek Week { get; set; }
		public string FileName { get; set; }
		public string Message { get; set; }
	}
}
