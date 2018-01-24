using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SealModSix.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CherwasGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
            base.SetStaticDefaults();
            DisplayName.SetDefault("Cherwa's Greaves");
            Tooltip.SetDefault("Cherwa's greaves."
                               + "Pretty awesome for summoning!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
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