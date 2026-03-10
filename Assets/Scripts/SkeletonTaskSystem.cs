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
                Debug.Log("Skeleton trabalhando: " + sk.currentTask);
                float production =
                    sk.GetProductionPerSecond() * Time.deltaTime;

                ResourceType producedResource =
                    TaskResourceMap.GetResource(sk.currentTask);

                ResourceManager.Instance
                    .AddResource(producedResource, production);
            }
        }
    }
}