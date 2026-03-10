using UnityEngine;
using TMPro;

public class SkeletonListItem : MonoBehaviour
{
    public TextMeshProUGUI idText;

    private SkeletonData skeletonData;
    private SkeletonManager skeletonManager;

    public void Setup(SkeletonData data, SkeletonManager manager)
    {
        skeletonData = data;
        skeletonManager = manager;

        idText.text = "Caveira #" + data.id;
    }

    public void OnClickDetails()
    {
        SkeletonDetailsUI.Instance.ShowDetails(skeletonData);
    }

    public void OnClickUnsummon()
    {
        skeletonManager.RemoveSkeleton(skeletonData.id);
    }

    public void OnClickJob()
    {
        OccupationPanel.Instance.OpenPanel(skeletonData);
    }
}