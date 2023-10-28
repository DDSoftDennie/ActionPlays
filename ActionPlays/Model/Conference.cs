namespace ActionPlays.Model
{
	public class Conference
	{
		public DateOnly From { get; set; }

		public DateOnly To { get; set; }

		public string Name { get; set; }

		public Conference(DateOnly from, DateOnly to, string name) { 
			if(from > to)
			{
                throw new ArgumentException("From date must be before To date");
            }
			
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
