using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TaskButton : MonoBehaviour
{
    public TextMeshProUGUI text;
    TaskType task;

    public void Setup(TaskType newTask, string label)
    {
        task = newTask;
        text.text = label;

        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        OccupationPanel.Instance.SetTask(task);
    }
}