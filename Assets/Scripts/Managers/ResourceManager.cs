using UnityEngine;
using System.Collections.Generic;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;

    private Dictionary<ResourceType, float> resources =
        new Dictionary<ResourceType, float>();

    void Awake()
    {
        Instance = this;

        // inicializa todos os recursos com 0
        foreach (ResourceType type in System.Enum.GetValues(typeof(ResourceType)))
        {
            resources[type] = 0f;
        }
    }

    public void AddResource(ResourceType type, float amount)
    {
        resources[type] += amount;
    }

    public float GetResource(ResourceType type)
    {
        return resources[type];
    }
}