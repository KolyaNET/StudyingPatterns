using Decorator.Grades;

namespace Decorator.LessonsInDepth
{
	/// <inheritdoc />
	/// <summary>
	/// Класс в школе с углубленным изучением физики.
	/// </summary>
	public sealed class PhysicsLessonInDepth : LessonInDepth
	{
		/// <inheritdoc />
		/// <summary>
		/// Конструктор класса в школе с углубленным изучением физики.
		/// </summary>
		/// <param name="grade">Класс в школе.</param>
		public PhysicsLessonInDepth(Grade grade)
			: base(grade.FullName + ", с углубленным изучением Физики", grade)
		{ }

		/// <inheritdoc />
		/// <summary>
		/// Получить сложность обучения в классе с углубленным изучением физики.
		/// </summary>
		/// <returns>Сложность обучения.</returns>
		public override int GetComplexityLearning()
		{
			return Grade.GetComplexityLearning() + 25;
		}
	}
}