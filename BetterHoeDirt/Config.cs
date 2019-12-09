using StardewModdingAPI;

namespace BetterHoeDirt
{
	class Config
	{
		public SButton debugKey { get; set; }

		public Config()
		{
			debugKey = SButton.J;
		}
	}
}
