namespace {{ Namespace }}
{
	public static class DeviceInfoExtensions
	{
		public static string ToPrettyModel(this string hardwareIdentifier)
		{
			switch (hardwareIdentifier)
			{
				{{#each Identifiers}}
				case "{{ @Key }}": return "{{ @Value }}";
				{{/each}}	
				default: return hardwareIdentifier;
			}
		}
	}
}