namespace Observer
{
	/// <summary>
	/// Ребенок учащийся в школе.
	/// </summary>
	public sealed class Child
	{
		/// <summary>
		/// Имя ребенка.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Фамилия ребенка.
		/// </summary>
		public string Surname { get; set; }

		/// <summary>
		/// Фамилия ребенка.
		/// </summary>
		public string FullName => Name + " " + Surname;
	}
}