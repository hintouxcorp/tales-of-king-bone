using UnityEngine;

public class UIScreenManager : MonoBehaviour
{
    public static UIScreenManager Instance;

    public GameObject summonsPanel;
    public GameObject resourcesPanel;

    void Awake()
    {
        Instance = this;
    }

    public void ShowSummons()
    {
        HideAll();
        summonsPanel.SetActive(true);
    }

    public void ShowResources()
    {
        HideAll();
        resourcesPanel.SetActive(true);
    }

    void HideAll()
    {
        summonsPanel.SetActive(false);
        resourcesPanel.SetActive(false);
    }
}