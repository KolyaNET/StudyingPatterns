using System;
using WebApplication.ViewModels.Classes;

namespace WebApplication.ViewModels
{
	/// <inheritdoc />
	/// <summary>
	/// Модель представление для общей страницы сайта.
	/// </summary>
	public class MasterPageViewModel : ContextViewModel
	{
		/// <summary>
		/// Заголовок страницы.
		/// </summary>
		public string Title { get; }

		public MasterPageViewModel(string title)
		{
			if (string.IsNullOrEmpty(title))
			{
				throw new ArgumentNullException(nameof(title), "Укажите заголовок страницы");
			}

			Title = $"{title} - StudyingPatterns";
		}
	}
}
