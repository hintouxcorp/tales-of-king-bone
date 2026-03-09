using UnityEngine;

public class SummonSystem : MonoBehaviour
{
    public ManaSystem manaSystem;
    public SkeletonManager skeletonManager;

    public float summonCost = 20f;

    public void SummonSkeleton()
    {
        if (manaSystem.CanSummon(summonCost))
        {
            manaSystem.SpendMana(summonCost);
            skeletonManager.AddSkeleton();
        }
    }
}