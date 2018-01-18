namespace AbstractFactory.Interfaces
{
	/// <summary>
	/// Алгоритм обработки фотографии.
	/// </summary>
	public abstract class AlgorithmProcessing
	{
		/// <summary>
		/// Обработать фотографию.
		/// </summary>
		/// <param name="photo">Фотография.</param>
		/// <returns>Обработанная фотография.</returns>
		public abstract byte[] Process(byte[] photo);
	}
}