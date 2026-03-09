public static class TaskResourceMap
{
    public static ResourceType GetResource(TaskType task)
    {
        switch (task)
        {
            case TaskType.GatherWood:
                return ResourceType.Wood;

            case TaskType.MineStone:
                return ResourceType.Stone;

            default:
                return ResourceType.Wood;
        }
    }
}