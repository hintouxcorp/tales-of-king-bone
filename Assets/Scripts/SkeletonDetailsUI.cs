using UnityEngine;
using TMPro;

public class SkeletonDetailsUI : MonoBehaviour
{
    public static SkeletonDetailsUI Instance;

    public GameObject panel;
    public TextMeshProUGUI idText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI manaDrainText;

    void Awake()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void ShowDetails(SkeletonData data)
    {
        panel.SetActive(true);

        idText.text = "ID: " + data.id;
        healthText.text = "Vida: " +
            data.currentHealth + "/" + data.maxHealth;

        manaDrainText.text =
            "Consumo de Mana: " +
            SkeletonManager.Instance.manaDrainPerSkeleton + "/s";
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}