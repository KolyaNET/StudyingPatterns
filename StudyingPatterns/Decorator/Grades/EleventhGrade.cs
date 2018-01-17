namespace Decorator.Grades
{
	/// <inheritdoc />
	/// <summary>
	/// Одиннадцатый класс в школе.
	/// </summary>
	public sealed class EleventhGrade : Grade
	{
		/// <inheritdoc />
		/// <summary>
		/// Конструктор одиннадцатого класса в школе.
		/// </summary>
		/// <param name="prefix">Префикс класса.</param>
		/// <param name="numberPupils">Количество учеников в классе.</param>
		public EleventhGrade(string prefix, int numberPupils) : base("Одиннадцатый")
		{
			NumberPupils = numberPupils;
			Prefix = prefix;
		}

		/// <inheritdoc />
		/// <summary>
		/// Получить сложность обучения в одиннадцатом классе.
		/// </summary>
		/// <returns>Сложность обучения</returns>
		public override int GetComplexityLearning()
		{
			return 120;
		}
	}
}