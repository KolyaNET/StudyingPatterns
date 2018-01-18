namespace AbstractFactory.Interfaces
{
	/// <summary>
	/// Хранилище фотографий.
	/// </summary>
	public abstract class Storage
	{
		/// <summary>
		/// Сохранить фотографию.
		/// </summary>
		/// <param name="photo">Фотография.</param>
		/// <returns>Результат сохранения.</returns>
		public abstract bool Save(byte[] photo);
	}
}