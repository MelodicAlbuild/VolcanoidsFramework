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
