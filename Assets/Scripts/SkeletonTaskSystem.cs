using UnityEngine;

public class SkeletonTaskSystem : MonoBehaviour
{
    public SkeletonManager skeletonManager;

    void Update()
    {
        foreach (var sk in skeletonManager.skeletons)
        {
            if (sk.state == SkeletonState.Working &&
                sk.currentTask != TaskType.None)
            {
                float production =
                    sk.GetProductionPerSecond() * Time.deltaTime;

                ResourceManager.Instance
                    .AddResource(sk.currentTask, production);
            }
        }
    }
}