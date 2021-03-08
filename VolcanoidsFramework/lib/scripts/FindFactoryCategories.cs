using System.Collections.Generic;
using System.Linq;

namespace VolcanoidsFramework.lib.scripts
{
    class FindFactoryCategories
    {
        public static FactoryType FindFactoryNames(string categoryName)
        {
            return GameResources.Instance.FactoryTypes.FirstOrDefault(type => type?.name == categoryName);
        }
    }
}
