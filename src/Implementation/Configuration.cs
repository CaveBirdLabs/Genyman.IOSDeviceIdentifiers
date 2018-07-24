using System.Collections.Generic;
using Genyman.Core;

namespace CaveBirdLabs.Genyman.IOSDeviceIdentifiers.Implementation
{
	[Documentation(Source="https://github.com/CaveBirdLabs/Genyman.IOSDeviceIdentifiers")]
	public class Configuration
	{
		[Description("The target namespace for the class")]
		public string Namespace { get; set; }
		
		[Ignore]
		public Dictionary<string,string> Identifiers { get; set; } = new Dictionary<string, string>();
	}
}		