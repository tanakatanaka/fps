using UnityEngine;
using UnityEngine.Events;

public class Objective : MonoBehaviour
{
    [Tooltip("Short text explaining the objective that will be shown on screen")]
    public string title;
    [Tooltip("Short text explaining the objective that will be shown on screen")]
    public string description;
    [Tooltip("Whether the objective is required to win or not")]
    public bool isOptional;
    [Tooltip("Delay before theobjective becomes visible")]
    public float delayVisible;

    public bool isCompleted { get; private set; }
    public bool isBlocking() => !(isOptional || isCompleted);

    public UnityAction<UnityActionUpdateObjective> onUpdateObjective;

    //NotificationHUDManager m_NotificationHUDManager;
    //ObjectiveHUDManger m_ObjectiveHUDManger;

    void Start()
    {

    }
}

public class UnityActionUpdateObjective
{
    public Objective objective;
    public string descriptionText;
    public string counterText;
    public bool isComplete;
    public string notificationText;

    public UnityActionUpdateObjective(Objective objective, string descriptionText, string counterText, bool isComplete, string notificationText)
    {
        this.objective = objective;
        this.descriptionText = descriptionText;
        this.counterText = counterText;
        this.isComplete = isComplete;
        this.notificationText = notificationText;
    }
}
