[System.Serializable]
public class SkeletonData
{
    public int id;

    public SkeletonState state = SkeletonState.Idle;
    public TaskType currentTask = TaskType.None;

    // Vida
    public float maxHealth = 100f;
    public float currentHealth;

    // Atributos base
    public float gatherSpeed = 1f;
    public float gatherAmountPerSecond = 1f;

    public SkeletonData(int id)
    {
        this.id = id;
        currentHealth = maxHealth;
    }

    public void AssignTask(TaskType task)
    {
        currentTask = task;
        state = SkeletonState.Working;
    }

    public void StopTask()
    {
        currentTask = TaskType.None;
        state = SkeletonState.Idle;
    }

    public float GetProductionPerSecond()
    {
        if (state != SkeletonState.Working)
            return 0f;

        return gatherAmountPerSecond * gatherSpeed;
    }
}