using CaveBirdLabs.Genyman.IOSDeviceIdentifiers.Implementation;
using Genyman.Core;

namespace CaveBirdLabs.Genyman.IOSDeviceIdentifiers
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			GenymanApplication.Run<Configuration, NewTemplate, Generator>(args);
		}
	}
}