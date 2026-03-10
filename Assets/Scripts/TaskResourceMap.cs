public static class TaskResourceMap
{
    public static ResourceType GetResource(TaskType task)
    {
        switch (task)
        {   
            //Gather
            case TaskType.GatherWood:
                return ResourceType.Wood;
            case TaskType.GatherLeaf:
                return ResourceType.Leaf;

            //Mine
            case TaskType.MineStone:
                return ResourceType.Stone;

            //Hunt
            case TaskType.HuntWolf:
                return ResourceType.Wolf;

            //Craft
            case TaskType.CraftSmallPotion:
                return ResourceType.SmallPotion;

            default:
                return ResourceType.Wood;
        }
    }
}