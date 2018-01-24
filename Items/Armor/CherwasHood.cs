using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SealModSix.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CherwasHood : ModItem
	{
		public override void SetStaticDefaults()
		{
            base.SetStaticDefaults();
            DisplayName.SetDefault("Cherwa's Hood");
            Tooltip.SetDefault("Cherwa's hood."
                               + "Pretty awesome for summoning!");
        }

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "trollface.jpg";
			player.AddBuff(BuffID.Cursed, 2);
			player.AddBuff(BuffID.Darkness, 2);
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