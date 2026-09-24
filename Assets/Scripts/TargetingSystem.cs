using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
    [SerializeField]
    private AbilityController abilityController;

    [SerializeField]
    private HealthComponent target;

    private void Start()
    {
        if (abilityController == null)
        {
            abilityController = GetComponent<AbilityController>();
        }

        if (target != null)
        {
            abilityController.SetTarget(target);
        }
    }
}