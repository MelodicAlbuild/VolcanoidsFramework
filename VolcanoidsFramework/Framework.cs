using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VolcanoidsFramework.lib;
using VolcanoidsFramework.lib.scripts;

namespace VolcanoidsFramework
{
    public class Framework
    {
        private const string version = "1.0.0";
        public Framework(string modName)
        {
            Debug.Log("Volcanoids Modding Framework Version " + version + " has been Enabled for Mod " + modName);
        }

        public void CreateModule(string codename, string variantname, int maxstack, string baseitem, LocalizedString name, LocalizedString desc, string guidstring, string categoryname, string factorytypename, string iconPath, string[] categoryList, bool looping)
        {
            Sprite icon = SpriteGenerator.GenerateSprite(iconPath);
            RecipeCategory[] categories = GenerateCategories.GenerateCategoryArray(categoryList);
            if (looping)
            {
                Module.CreateProductionModule(codename, variantname, maxstack, baseitem, name, desc, guidstring, categoryname, factorytypename, icon, categories, true);
            }
            else
            {
                Module.CreateProductionModule(codename, variantname, maxstack, baseitem, name, desc, guidstring, categoryname, factorytypename, icon, categories);
            }
        }

        public void CreateItem(string codename, int maxstack, LocalizedString name, LocalizedString desc, string guidstring, string recipecategoryname, string iconPath)
        {
            Sprite icon = SpriteGenerator.GenerateSprite(iconPath);
            Item.CreateItem(codename, maxstack, name, desc, guidstring, recipecategoryname, icon);
        }

        public void CreateDeposit(bool Underground, int PercentageToReplace, string outputname, float minyield, float maxyield, string ItemToReplace)
        {
            Deposit.CreateDeposit(Underground, PercentageToReplace, outputname, minyield, maxyield, ItemToReplace);
        }

        public void CreateRecipe(string recipeName, lib.classes.Input[] inputs, object[] outputs, string baseRecipe, string itemId, string[] requiredItems, string recipeCategory)
        {
            RecipeCreator.CreateRecipe(recipeName, inputs, outputs, baseRecipe, itemId, requiredItems, recipeCategory);
        }

        public void CreateStation(string factoryTypeName, string codename, int maxStack, LocalizedString name, LocalizedString desc, string guidString, string iconPath, string variantname, string[] categoryList)
        {
            FactoryType factoryType = FindFactoryCategories.FindFactoryNames(factoryTypeName);
            Sprite icon = SpriteGenerator.GenerateSprite(iconPath);
            RecipeCategory[] categories = GenerateCategories.GenerateCategoryArray(categoryList);
            Station.CreateStation(factoryType, codename, maxStack, name, desc, guidString, icon, variantname, categories);
        }
    }
}
