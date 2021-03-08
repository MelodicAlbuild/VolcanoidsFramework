using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolcanoidsFramework.lib.scripts
{
    class GenerateCategories
    {
        public static RecipeCategory[] GenerateCategoryArray(string[] categories)
        {
            RecipeCategory[] finalInput = new RecipeCategory[categories.Length];
            var i = 0;
            foreach (string category in categories)
            {
                finalInput[i] = FindCategory.FindCategoryName(category);
                i++;
            }
            return finalInput;
        }
    }
}
