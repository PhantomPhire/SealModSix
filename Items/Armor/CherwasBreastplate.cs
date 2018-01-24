using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SealModSix.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CherwasBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cherwa's Breastplate");
			Tooltip.SetDefault("Cherwa's breastplate."
                               + "Pretty awesome for summoning!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 12;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Dazed] = true;
            player.statManaMax2 += 20;
			player.maxMinions++;
            player.endurance += 0.1f;
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