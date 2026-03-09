using UnityEngine;
using TMPro;

public class SkeletonListUI : MonoBehaviour
{
    public SkeletonManager skeletonManager;
    public Transform contentParent;
    public GameObject listItemPrefab;

    void Start()
    {
        skeletonManager.OnSkeletonListChanged += RefreshList;
        RefreshList();
    }

    void OnDestroy()
    {
        skeletonManager.OnSkeletonListChanged -= RefreshList;
    }

    void RefreshList()
    {

        // Remove todos os filhos antigos
        for (int i = contentParent.childCount - 1; i >= 0; i--)
        {
            Destroy(contentParent.GetChild(i).gameObject);
        }

        // Recria os itens
        foreach (var sk in skeletonManager.skeletons)
        {
            GameObject item = Instantiate(listItemPrefab, contentParent);

            SkeletonListItem listItem = item.GetComponent<SkeletonListItem>();
            listItem.Setup(sk, skeletonManager);
        }

    }
}