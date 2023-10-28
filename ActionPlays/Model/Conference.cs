using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPlays.Model
{
	public class Conference
	{
		public DateOnly From { get; set; }

		public DateOnly To { get; set; }

		public string Name { get; set; }

		public Conference(DateOnly from, DateOnly to, string name) { 
			From = from;
			To = to;
			Name = name;
		}
		public override string ToString()
		{
            return $"Conference: {Name}, from {From} to {To}";
        }

	
	}
}
