using AbstractFactory.Classes.AlgorithmProcessing;
using AbstractFactory.Classes.Lens;
using AbstractFactory.Classes.Storage;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Cameras
{
	/// <inheritdoc />
	/// <summary>
	/// Фабрика создания современных яблочных камер для смартфонов компании.
	/// </summary>
	public sealed class ApplePhoneCameraFactory : CameraFactory
	{
		public override Interfaces.Lens CreateLens()
		{
			return new DoubleLens();
		}

		public override Interfaces.AlgorithmProcessing CreateAlgorithmProcessing()
		{
			return new GaussianBlurAlgorithmProcessing();
		}

		public override Interfaces.Storage CreateStorage()
		{
			return new FlashMemoryStorage();
		}
	}
}