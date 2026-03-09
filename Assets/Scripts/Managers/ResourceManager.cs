using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;

    public float wood;
    public float stone;

    void Awake()
    {
        Instance = this;
    }

    public void AddResource(TaskType task, float amount)
    {
        switch (task)
        {
            case TaskType.GatherWood:
                wood += amount;
                break;

            case TaskType.GatherStone:
                stone += amount;
                break;
        }
    }
}