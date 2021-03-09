using UnityEngine;
using VolcanoidsFramework.lib;
using VolcanoidsFramework.lib.scripts;

namespace VolcanoidsFramework
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> The Volcanoids Modding Framework Version 1.0.0. </summary>
    ///
    /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class Framework
    {
        /// <summary>   (Immutable) the version. </summary>
        private const string version = "1.0.0";

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Framework Builder. </summary>
        ///
        /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
        ///
        /// <param name="modName">  Name of the Mod your Making. </param>
        ///-------------------------------------------------------------------------------------------------

        public Framework(string modName)
        {
            Debug.Log("Volcanoids Modding Framework Version " + version + " has been Enabled for Mod " + modName);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Creates a Module. </summary>
        ///
        /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
        ///
        /// <param name="codename">         The Name of the Module with NO SPACES. </param>
        /// <param name="variantname">      The Name of the Variant, Such as Tier1 or Tier2. </param>
        /// <param name="maxstack">         The Maximum you can have of this item in a stack. </param>
        /// <param name="baseitem">         The Item to Base this object off, Pick a Module with the same
        ///                                 Variant. </param>
        /// <param name="name">             The Spaced Name of your Module. </param>
        /// <param name="desc">             The Description of your Module. </param>
        /// <param name="guidstring">       The GUID in String Form for your module. </param>
        /// <param name="categoryname">     The Category in which your Module is in. </param>
        /// <param name="factorytypename">  The Factory Type that is Module is a Part of. </param>
        /// <param name="iconPath">         Full pathname of the icon file. </param>
        /// <param name="categoryList">     Array of Strings for Categories for the Module Item to be
        ///                                 placed in. </param>
        /// <param name="looping">          If you are creating a new FactoryType, This is true for the
        ///                                 first Module in that category, False at all other times. </param>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Creates an item. </summary>
        ///
        /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
        ///
        /// <param name="codename">             The Name of the Module with NO SPACES. </param>
        /// <param name="maxstack">             The Maximum you can have of this item in a stack. </param>
        /// <param name="name">                 The Spaced Name of your Module. </param>
        /// <param name="desc">                 The Description of your Module. </param>
        /// <param name="guidstring">           The GUID in String Form for your module. </param>
        /// <param name="recipecategoryname">   The Base Item for your Item. </param>
        /// <param name="iconPath">             Full pathname of the icon file. </param>
        ///-------------------------------------------------------------------------------------------------

        public void CreateItem(string codename, int maxstack, LocalizedString name, LocalizedString desc, string guidstring, string recipecategoryname, string iconPath)
        {
            Sprite icon = SpriteGenerator.GenerateSprite(iconPath);
            Item.CreateItem(codename, maxstack, name, desc, guidstring, recipecategoryname, icon);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Creates a deposit. </summary>
        ///
        /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
        ///
        /// <param name="Underground">          If this is an Underground Deposit. </param>
        /// <param name="PercentageToReplace">  The percentage to replace. </param>
        /// <param name="outputname">           The Item to Output when Mined. </param>
        /// <param name="minyield">             The Minimum Amount the Deposit can give. </param>
        /// <param name="maxyield">             The Maximum Amount the Deposit can give. </param>
        /// <param name="ItemToReplace">        The Deposit Item to Replace. </param>
        ///-------------------------------------------------------------------------------------------------

        public void CreateDeposit(bool Underground, int PercentageToReplace, string outputname, float minyield, float maxyield, string ItemToReplace)
        {
            Deposit.CreateDeposit(Underground, PercentageToReplace, outputname, minyield, maxyield, ItemToReplace);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Creates a recipe. </summary>
        ///
        /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
        ///
        /// <param name="recipeName">       Name of the recipe. </param>
        /// <param name="inputs">           The inputs of the Recipe. Uses
        ///                                 VolcanoidsFramework.lib.classes.Input. </param>
        /// <param name="outputs">          The outputs of your Recipe. Uses
        ///                                 VolcanoidsFramework.lib.classes.Output. </param>
        /// <param name="baseRecipe">       The base recipe. </param>
        /// <param name="itemId">           GUID for the item. </param>
        /// <param name="requiredItems">    The required items (Schematics) to create this Recipe. </param>
        /// <param name="recipeCategory">   Category the recipe belongs to. </param>
        ///-------------------------------------------------------------------------------------------------

        public void CreateRecipe(string recipeName, lib.classes.Input[] inputs, object[] outputs, string baseRecipe, string itemId, string[] requiredItems, string recipeCategory)
        {
            RecipeCreator.CreateRecipe(recipeName, inputs, outputs, baseRecipe, itemId, requiredItems, recipeCategory);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Creates a station. </summary>
        ///
        /// <remarks>   MelodicAlbuild, 3/8/2021. </remarks>
        ///
        /// <param name="factoryTypeName">  Name of the factory type for this Station to use. </param>
        /// <param name="codename">         The Name of the Module with NO SPACES. </param>
        /// <param name="maxStack">         The Maximum you can have of this item in a stack. </param>
        /// <param name="name">             The Spaced Name of your Module. </param>
        /// <param name="desc">             The Description of your Module. </param>
        /// <param name="guidString">       The GUID for this Item. </param>
        /// <param name="iconPath">         Full pathname of the icon file. </param>
        /// <param name="variantname">      The Name of the Variant, Such as Tier1 or Tier2. </param>
        /// <param name="categoryList">     Array of Strings for Categories for the Station Item to be
        ///                                 placed in. </param>
        ///-------------------------------------------------------------------------------------------------

        public void CreateStation(string factoryTypeName, string codename, int maxStack, LocalizedString name, LocalizedString desc, string guidString, string iconPath, string variantname, string[] categoryList)
        {
            FactoryType factoryType = FindFactoryCategories.FindFactoryNames(factoryTypeName);
            Sprite icon = SpriteGenerator.GenerateSprite(iconPath);
            RecipeCategory[] categories = GenerateCategories.GenerateCategoryArray(categoryList);
            Station.CreateStation(factoryType, codename, maxStack, name, desc, guidString, icon, variantname, categories);
        }
    }
}
