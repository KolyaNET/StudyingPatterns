namespace Decorator.Grades
{
	/// <inheritdoc />
	/// <summary>
	/// Первый класс в школе.
	/// </summary>
    public sealed class FirstGrade : Grade
	{
		/// <inheritdoc />
		/// <summary>
		/// Конструктор первого класса в школе.
		/// </summary>
		/// <param name="prefix">Префикс класса.</param>
		/// <param name="numberPupils">Количество учеников в классе.</param>
		public FirstGrade(string prefix, int numberPupils) : base("Первый")
		{
			NumberPupils = numberPupils;
			Prefix = prefix;
		}

		/// <inheritdoc />
		/// <summary>
		/// Получить сложность обучения в первом классе.
		/// </summary>
		/// <returns>Сложность обучения</returns>
		public override int GetComplexityLearning()
		{
			return 10;
		}
	}
}