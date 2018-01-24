using Terraria.ModLoader;
using Terraria.ID;

namespace SealModSix.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	class CherwasRobe : ModItem
	{
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Cherwa's Robe");
            Tooltip.SetDefault("Cherwa's robe."
                               + "Pretty awesome for summoning!");
        }

        public override void SetDefaults()
		{
			item.width = 18;
			item.height = 14;
			item.rare = 1;
			item.vanity = true;
		}

		public override void SetMatch(bool male, ref int equipSlot, ref bool robes)
		{
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("ExampleRobe_Legs", EquipType.Legs);
		}
		
		public override void DrawHands(ref bool drawHands, ref bool drawArms)
		{
			drawHands = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
