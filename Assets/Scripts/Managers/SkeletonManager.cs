using System.Collections.Generic;
using UnityEngine;
using System;

public class SkeletonManager : MonoBehaviour
{
    public List<SkeletonData> skeletons = new List<SkeletonData>();

    private int nextID = 0;

    public float manaDrainPerSkeleton = 2f; // custo fixo por caveira
    public static SkeletonManager Instance;
    public event Action OnSkeletonListChanged;

    void Awake()
    {
        Instance = this;
    }
    public void AddSkeleton()
    {
        SkeletonData newSkeleton = new SkeletonData(nextID);

        skeletons.Add(newSkeleton);
        nextID++;

        OnSkeletonListChanged?.Invoke();
    }

    public void RemoveSkeleton(int id)
    {
        SkeletonData toRemove = skeletons.Find(s => s.id == id);

        if (toRemove != null)
        {
            skeletons.Remove(toRemove);
            OnSkeletonListChanged?.Invoke();
        }
    }

    public void RemoveAllSkeletons()
    {
        skeletons.Clear();
        OnSkeletonListChanged?.Invoke();
    }

    public float GetTotalManaDrain()
    {
        return skeletons.Count * manaDrainPerSkeleton;
    }
}