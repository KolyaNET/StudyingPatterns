using Decorator.Grades;

namespace Decorator.LessonsInDepth
{
	/// <inheritdoc />
	/// <summary>
	/// Класс в школе с углубленным изучением английского языка.
	/// </summary>
	public sealed class EnglishLessonInDepth : LessonInDepth
	{
		/// <inheritdoc />
		/// <summary>
		/// Конструктор класса в школе с углубленным изучением английского языка.
		/// </summary>
		/// <param name="grade">Класс в школе.</param>
		public EnglishLessonInDepth(Grade grade)
			: base(grade.FullName + ", с углубленным изучением Английского языка", grade)
		{ }

		/// <inheritdoc />
		/// <summary>
		/// Получить сложность обучения в классе с углубленным изучением английского языка.
		/// </summary>
		/// <returns>Сложность обучения.</returns>
		public override int GetComplexityLearning()
		{
			return Grade.GetComplexityLearning() + 15;
		}
	}
}