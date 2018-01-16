using Observer;
using Singleton;
using System;

namespace ConsoleApplication
{
	internal class Program
	{
		private static void Main()
		{
			Console.WriteLine("// Программа начала свою работу. //");

			try
			{
				Singleton();

				Observer();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			
			Console.WriteLine("// Программа завершила свою работу. //");
			Console.ReadLine();
		}

		private static void Singleton()
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
		}

		private static void Observer()
		{
			Console.WriteLine("-- Observer --");

			var schoolJournal = new SchoolJournal();

			// TODO: Потенциальная ошибка - обращение по индексу.
			var father = new Father("Петр Ильич", SchoolInfo.Children[1], schoolJournal);

			// TODO: Потенциальная ошибка - обращение по индексу.
			var unused = new Grandmother("Аврора Сергеевна", SchoolInfo.Children[0], schoolJournal);

			// Имитация выставления нескольких оценок.
			schoolJournal.Valuation();
			father.StopNotificate();
			schoolJournal.Valuation();
			schoolJournal.Valuation();
		}
	}
}
