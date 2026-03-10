using UnityEngine;

public class OccupationPanel : MonoBehaviour
{
    public static OccupationPanel Instance;

    public Transform content;
    public GameObject taskButtonPrefab;

    SkeletonData selectedSkeleton;

    void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    public void OpenPanel(SkeletonData skeleton)
    {
        selectedSkeleton = skeleton;
        gameObject.SetActive(true);
    }

    public void SetTask(TaskType task)
    {
        selectedSkeleton.currentTask = task;
        selectedSkeleton.state = SkeletonState.Working;

        gameObject.SetActive(false);
    }

    void ClearButtons()
    {
        for (int i = content.childCount - 1; i >= 0; i--)
            Destroy(content.GetChild(i).gameObject);
    }

    void CreateButton(TaskType task, string label)
    {
        GameObject obj = Instantiate(taskButtonPrefab, content);

        TaskButton button = obj.GetComponent<TaskButton>();
        button.Setup(task, label);
    }

    // CATEGORIAS

    public void ShowGathering()
    {
        ClearButtons();

        CreateButton(TaskType.GatherWood, "Wood");
    }

    public void ShowMining()
    {
        ClearButtons();

        CreateButton(TaskType.MineStone, "Stone");
    }
}