using System;
using System.Collections.Generic;
using Genyman.Core;

namespace CaveBirdLabs.Genyman.IOSDeviceIdentifiers.Implementation
{
	public class Configuration
	{
		public string Namespace { get; set; }
		
		[GenymanIgnore]
		public Dictionary<string,string> Identifiers { get; set; } = new Dictionary<string, string>();
	}
}		