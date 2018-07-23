using System;
using System.Collections.Generic;
using Genyman.Core;
using Genyman.Core.Helpers;
using McMaster.Extensions.CommandLineUtils;
using ServiceStack;

namespace CaveBirdLabs.Genyman.IOSDeviceIdentifiers.Implementation
{
	public class Generator : GenymanGenerator<Configuration>
	{
		public override void Execute()
		{
			try
			{
				const string url = "https://raw.githubusercontent.com/fieldnotescommunities/ios-device-identifiers/master/ios-device-identifiers.json";
				Configuration.Identifiers = url.GetJsonFromUrl().FromJson<Dictionary<string, string>>();
				Overwrite = true; // always overwrite
				ProcessHandlebarTemplates();
			}
			catch (Exception e)
			{
				Log.Fatal(e.Message);
			}
		}
	}
}