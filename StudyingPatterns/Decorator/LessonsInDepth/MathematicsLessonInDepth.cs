using Decorator.Grades;

namespace Decorator.LessonsInDepth
{
	/// <inheritdoc />
	/// <summary>
	/// Класс в школе с углубленным изучением математики.
	/// </summary>
	public sealed class MathematicsLessonInDepth : LessonInDepth
	{
		/// <inheritdoc />
		/// <summary>
		/// Конструктор класса в школе с углубленным изучением математики.
		/// </summary>
		/// <param name="grade">Класс в школе.</param>
		public MathematicsLessonInDepth(Grade grade)
			: base(grade.FullName + ", с углубленным изучением Математики", grade)
		{ }

		/// <inheritdoc />
		/// <summary>
		/// Получить сложность обучения в классе с углубленным изучением математики.
		/// </summary>
		/// <returns>Сложность обучения.</returns>
		public override int GetComplexityLearning()
		{
			return Grade.GetComplexityLearning() + 20;
		}
	}
}