using AbstractFactory.Classes.AlgorithmProcessing;
using AbstractFactory.Classes.Lens;
using AbstractFactory.Classes.Storage;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Cameras
{
	/// <inheritdoc />
	/// <summary>
	/// Фабрика создания современных корейских камер для смартфонов компании.
	/// </summary>
	public sealed class SamsungPhoneCameraFactory : CameraFactory
	{
		public override Interfaces.Lens CreateLens()
		{
			return new OneLens();
		}

		public override Interfaces.AlgorithmProcessing CreateAlgorithmProcessing()
		{
			return new SmoothingAlgorithmProcessing();
		}

		public override Interfaces.Storage CreateStorage()
		{
			return new CardMemoryStorage();
		}
	}
}