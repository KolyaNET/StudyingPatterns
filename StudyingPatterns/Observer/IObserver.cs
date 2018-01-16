namespace Observer
{
	/// <summary>
	/// Подписчик на школьный журнал (издатель).
	/// </summary>
	public interface IObserver
	{
		/// <summary>
		/// Метод для получения уведомлений от школьного журнала (издателя).
		/// </summary>
		/// <param name="ob">Передаваемый объект с информацией от школы.</param>
		void Update(object ob);
	}
}