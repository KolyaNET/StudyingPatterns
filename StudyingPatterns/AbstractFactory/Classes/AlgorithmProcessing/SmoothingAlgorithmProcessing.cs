namespace AbstractFactory.Classes.AlgorithmProcessing
{
	/// <inheritdoc />
	/// <summary>
	/// Сглаживание - Алгоритм обработки фотографии.
	/// </summary>
	public sealed class SmoothingAlgorithmProcessing : Interfaces.AlgorithmProcessing
	{
		/// <inheritdoc />
		/// <summary>
		/// Обработать фотографию.
		/// </summary>
		/// <param name="photo">Фотография.</param>
		/// <returns>Обработанная фотография.</returns>
		public override byte[] Process(byte[] photo)
		{
			var tempPhoto = photo;
			// Выполняем преобразования ...
			return tempPhoto;
		}
	}
}