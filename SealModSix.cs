using Terraria.ModLoader;

namespace SealModSix
{
	class SealModSix : Mod
	{
		public SealModSix()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
