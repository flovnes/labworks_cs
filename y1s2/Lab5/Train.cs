namespace lab5_serialization {
	public struct Train : IComparable<Train>
	{
		public string Name { get; set; }
		public int Number { get; set; }
		public string TimeOfDeparture { get; set; }

		public Train(string name, int num, string timeOfDeparture) {
			Name = name;
			Number = num;
			TimeOfDeparture = timeOfDeparture;
		}

    public Train(string input) {
      string[] fields = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      Name = fields[0];
      Number = int.Parse(fields[1]);
      TimeOfDeparture = fields[2];
    }

		public override readonly string ToString() {
			return $"[{Number}] {Name}, час відправлення: {TimeOfDeparture}";
		}

		public readonly int CompareTo(Train other) {
			return (Number > other.Number) ? 1 : -1;
		}
	}
}