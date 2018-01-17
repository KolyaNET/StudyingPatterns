namespace Singleton
{
	/// <summary>
	/// Класс описывает школу
	/// </summary>
    public sealed class School
    {
		/// <summary>
		/// Директор школы
		/// </summary>
		public HeadTeacher HeadTeacher { get; set; }

		/// <summary>
		/// Назначение директора. Вот такая у нас интересная школа, без директора ни как.
		/// </summary>
		/// <param name="headTeacherName">Имя директора школы</param>
		public void Appoint(string headTeacherName)
	    {
		    HeadTeacher = HeadTeacher.GetInstance(headTeacherName);
	    }
	}
}
