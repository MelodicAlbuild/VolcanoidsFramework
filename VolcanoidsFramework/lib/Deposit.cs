using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace VolcanoidsFramework.lib
{
    class Deposit
    {
        public static void CreateDeposit(bool Underground, int PercentageToReplace, string outputname, float minyield, float maxyield, string ItemToReplace)
        {

            if (Underground)
            {
                foreach (DepositLocationUnderground underground in depositunderground)
                {
                    if (Random.Range(0, 100) <= PercentageToReplace)
                    {
                        if ((ItemToReplace != null && underground.Ore == GetItem(ItemToReplace)) || ItemToReplace == null)
                        {
                            underground.Yield = Random.Range(minyield, maxyield);
                            OreField.SetValue(underground, GetItem(outputname));
                        }
                    }
                }
            }
            if (!Underground)
            {
                foreach (DepositLocationSurface surface in depositsurface)
                {
                    if (Random.Range(0, 100) <= PercentageToReplace)
                    {
                        if ((ItemToReplace != null && surface.Ore == GetItem(ItemToReplace)) || ItemToReplace == null)
                        {
                            surface.Yield = Random.Range(minyield, maxyield);
                            OreField.SetValue(surface, GetItem(outputname));
                        }
                    }
                }
            }
        }
        private static ItemDefinition GetItem(string itemname)
        {
            ItemDefinition item = GameResources.Instance.Items.FirstOrDefault(s => s.name == itemname);
            if (item == null)
            {
                Debug.LogError("Item is null, name: " + itemname + ". Replacing with NullItem");
                return GameResources.Instance.Items.FirstOrDefault(s => s.name == "NullItem");
            }
            return item;

        }
        private static DepositLocationSurface[] depositsurface;
        private static DepositLocationUnderground[] depositunderground;
        private static readonly FieldInfo OreField = typeof(DepositLocation).GetField("m_ore", BindingFlags.NonPublic | BindingFlags.Instance);
    }
}
