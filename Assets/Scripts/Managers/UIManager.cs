using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerStats playerStats;
    public ManaSystem manaSystem;
    public SkeletonManager skeletonManager;

    public Image healthFill;
    public Image manaFill;
    public TextMeshProUGUI skeletonText;

    void Update()
    {
        UpdateHealthBar();
        UpdateManaBar();
        UpdateSkeletonText();
    }

    void UpdateHealthBar()
    {
        healthFill.fillAmount =
            playerStats.currentHealth / playerStats.maxHealth;
    }

    void UpdateManaBar()
    {
        manaFill.fillAmount =
            manaSystem.currentMana / manaSystem.maxMana;
    }

    void UpdateSkeletonText()
    {
        skeletonText.text = "Caveiras: " + skeletonManager.skeletons.Count;
    }
}