using UnityEngine;
using TMPro;
using System.Text;

public class ResourcesUI : MonoBehaviour
{
    public TextMeshProUGUI resourcesText;

    void Update()
    {
        StringBuilder sb = new StringBuilder();

        foreach (ResourceType type in System.Enum.GetValues(typeof(ResourceType)))
        {
            float value = ResourceManager.Instance.GetResource(type);

            sb.AppendLine(type + ": " + value.ToString("F0"));
        }

        resourcesText.text = sb.ToString();
    }
}