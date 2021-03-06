﻿using Observer;
using Singleton;
using System;
using AbstractFactory.Classes.Cameras;
using Decorator.Grades;
using Decorator.LessonsInDepth;
using AbstractFactory.Interfaces;

namespace ConsoleApplication
{
	internal sealed class Program
	{
		private static void Main()
		{
			Console.WriteLine("// Программа начала свою работу. // \n\r");

			try
			{
				Singleton();

				Observer();

				Decorator();

				AbstractFactory();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			
			Console.WriteLine("\n\r // Программа завершила свою работу. //");
			Console.ReadLine();
		}

		/// <summary>
		/// Пример работы Singleton.
		/// </summary>
		private static void Singleton()
		{
			Console.WriteLine("-- Singleton -- \n\r");

			var school = new School();
			school.Appoint("Иванова Светлана Петровна");
			Console.WriteLine("Назначение директора школе.");
			Console.WriteLine("Имя директора: " + school.HeadTeacher.Name);

			// Пытаемся изменить директора школы. Но у нас ничего не выйдет.
			school.HeadTeacher = HeadTeacher.GetInstance("Малинкина Анна Сергеевна");
			Console.WriteLine("Имя директора после изменения: " + school.HeadTeacher.Name);
			Console.WriteLine("Как и должно имя не изменилось.");
		}

		/// <summary>
		/// Пример работы Observer.
		/// </summary>
		private static void Observer()
		{
			Console.WriteLine("\n\r-- Observer -- \n\r");

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

		/// <summary>
		/// Пример работы Decorator.
		/// </summary>
		private static void Decorator()
		{
			Console.WriteLine("\n\r-- Decorator -- \n\r");

			Grade firstGrade = new FirstGrade("A", 15);
			// Первый А с углубленным изучением математики.
			firstGrade = new MathematicsLessonInDepth(firstGrade); 
			WriteGrade(firstGrade);

			Grade fifthGradeA = new FifthGrade("A", 35);
			// Пятый А с углубленным изучением английского языка.
			fifthGradeA = new EnglishLessonInDepth(fifthGradeA);
			WriteGrade(fifthGradeA);

			Grade fifthGradeB = new FifthGrade("B", 27);
			// Пятый B с углубленным изучением физики.
			fifthGradeB = new PhysicsLessonInDepth(fifthGradeB);
			WriteGrade(fifthGradeB);

			Grade leventhGrade = new EleventhGrade("A", 20);
			// Одиннадцатый А с углубленным изучением математики и физики.
			leventhGrade = new MathematicsLessonInDepth(leventhGrade);
			leventhGrade = new PhysicsLessonInDepth(leventhGrade);
			WriteGrade(leventhGrade);

			void WriteGrade(Grade grade)
			{
				if (grade == null)
				{
					throw new ArgumentNullException(nameof(grade), "Не указан класс в школе.");
				}

				Console.WriteLine($"Название: {grade.FullName}. Сложность обучения: {grade.GetComplexityLearning()}");
			}
		}

		/// <summary>
		/// Пример работы Abstract Factory.
		/// </summary>
		private static void AbstractFactory()
		{
			Console.WriteLine("\n\r-- Abstract Factory -- \n\r");

			var iPhoneXCamera = new Camera(new ApplePhoneCameraFactory());
			Console.WriteLine("Создали камеру IPhone X.");
			var photoIPhoneXCamera = iPhoneXCamera.TakePhoto();
			Console.WriteLine("Сделали фото на камеру IPhone X.");
			photoIPhoneXCamera = iPhoneXCamera.Process(photoIPhoneXCamera);
			Console.WriteLine("Преобразовали фото на камеру IPhone X.");
			var resultSavePhotoIPhoneXCamera = iPhoneXCamera.Save(photoIPhoneXCamera);
			Console.WriteLine($"Сохранили фото сделанное на камеру IPhone X. Результат сохранения: {resultSavePhotoIPhoneXCamera}");

			var galaxy8Camera = new Camera(new SamsungPhoneCameraFactory());
			Console.WriteLine("\n\rСоздали камеру Galaxy 9.");
			var photoGalaxy8Camera = galaxy8Camera.TakePhoto();
			Console.WriteLine("Сделали фото на камеру Galaxy 9.");
			photoGalaxy8Camera = galaxy8Camera.Process(photoGalaxy8Camera);
			Console.WriteLine("Преобразовали фото на камеру Galaxy 9.");
			var resultSaveGalaxy8Camera = galaxy8Camera.Save(photoGalaxy8Camera);
			Console.WriteLine($"Сохранили фото сделанное на камеру Galaxy 9. Результат сохранения: {resultSaveGalaxy8Camera}");
		}
	}
}