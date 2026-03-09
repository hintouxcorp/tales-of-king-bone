using UnityEngine;

public class ManaSystem : MonoBehaviour
{
    public float maxMana = 100f;
    public float currentMana;
    public float manaRegen = 5f;

    public SkeletonManager skeletonManager;

    void Start()
    {
        currentMana = maxMana;
    }

    void Update()
    {
        RegenerateMana();
        DrainMana();
        CheckMana();
    }

    void RegenerateMana()
    {
        currentMana += manaRegen * Time.deltaTime;
        currentMana = Mathf.Clamp(currentMana, 0, maxMana);
    }

    void DrainMana()
    {
        float totalDrain = skeletonManager.GetTotalManaDrain();
        currentMana -= totalDrain * Time.deltaTime;
    }

    void CheckMana()
    {
        if (currentMana <= 0)
        {
            currentMana = 0;
            skeletonManager.RemoveAllSkeletons();
        }
    }

    public bool CanSummon(float cost)
    {
        return currentMana >= cost;
    }

    public void SpendMana(float amount)
    {
        currentMana -= amount;
    }
}