namespace AbstractFactory.Interfaces
{
	/// <summary>
	/// Класс камеры для съемки фотографий.
	/// </summary>
	public sealed class Camera
	{
		private readonly Lens _lens;
		private readonly AlgorithmProcessing _algorithmProcessing;
		private readonly Storage _storage;

		public Camera(CameraFactory cameraFactory)
		{
			_lens = cameraFactory.CreateLens();
			_algorithmProcessing = cameraFactory.CreateAlgorithmProcessing();
			_storage = cameraFactory.CreateStorage();
		}

		/// <summary>
		/// Сделать фотографию.
		/// </summary>
		/// <returns>Фотография.</returns>
		public byte[] TakePhoto()
		{
			return _lens.TakePhoto();
		}

		/// <summary>
		/// Обработать фотографию.
		/// </summary>
		/// <param name="photo">Фотография.</param>
		/// <returns>Обработанная фотография.</returns>
		public byte[] Process(byte[] photo)
		{
			return _algorithmProcessing.Process(photo);
		}

		/// <summary>
		/// Сохранить фотографию.
		/// </summary>
		/// <param name="photo">Фотография.</param>
		/// <returns>Результат сохранения.</returns>
		public bool Save(byte[] photo)
		{
			return _storage.Save(photo);
		}
	}
}