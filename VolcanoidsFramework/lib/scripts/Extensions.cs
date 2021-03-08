using System.Reflection;
using UnityEngine;

namespace VolcanoidsFramework.lib.scripts
{
    public static class Extensions
    {
        public static bool SetPrivateField<T>(this T obj, string fieldName, object newValue)
        {
            var fieldInfo = typeof(ItemDefinition).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            if (fieldInfo == null)
            {
                Debug.LogError($"Error: Unable to find private field `{fieldName}` in `{typeof(T)}`.");
                return false;
            }
            fieldInfo.SetValue(obj, newValue);
            return true;
        }
    }
}
