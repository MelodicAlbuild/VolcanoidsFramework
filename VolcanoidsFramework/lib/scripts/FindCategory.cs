namespace VolcanoidsFramework.lib.scripts
{
    class FindCategory
    {
        private static RecipeCategory tempcategory;
        public static RecipeCategory FindCategoryName(string categoryname)
        {
            tempcategory = null;
            foreach (Recipe recipe in GameResources.Instance.Recipes)
            {
                foreach (RecipeCategory category in recipe.Categories)
                {
                    if (category != null && categoryname != null)
                    {
                        if (category.name == categoryname)
                        {
                            tempcategory = category;
                        }
                    }
                }
            }
            return tempcategory;
        }
    }
}
