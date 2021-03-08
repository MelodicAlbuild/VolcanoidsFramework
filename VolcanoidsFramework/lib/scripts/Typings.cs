namespace VolcanoidsFramework.lib.scripts
{
    class Typings
    {
        public static TrainProduction.GroupInfo GetOrCreateTyping(FactoryType factoryType)
        {
            TrainProduction production = new TrainProduction();
            return production.GetOrCreate(factoryType);
        }
    }
}
