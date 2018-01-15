using Singleton;
using System;

namespace ConsoleApplication
{
	internal class Program
	{
		private static void Main()
		{
			Console.WriteLine("-- Singleton --");

			var school = new School();
			school.Appoint("Иванова Светлана Петровна");
			Console.WriteLine("Назначение директора школе.");
			Console.WriteLine("Имя директора: " + school.HeadTeacher.Name);

			// Пытаемся изменить директора школы. Но у нас ничего не выйдет.
			school.HeadTeacher = HeadTeacher.GetInstance("Малинкина Анна Сергеевна");
			Console.WriteLine("Имя директора после изменения: " + school.HeadTeacher.Name);
			Console.WriteLine("Как и должно имя не изменилось.");

			Console.ReadLine();
		}
	}
}
