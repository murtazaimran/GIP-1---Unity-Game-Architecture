using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
    [SerializeField]
    private AbilityController abilityController;

    [SerializeField]
    private float targetingRange = 10f;

    private void Awake()
    {
        if (abilityController == null)
        {
            abilityController = GetComponent<AbilityController>();
        }

        if (abilityController == null)
        {
            Debug.LogError(
                "TargetingSystem could not find AbilityController."
            );
        }
    }

    public void UpdateTarget()
    {
        HealthComponent target = FindNearestTarget();

        abilityController.SetTarget(target);
    }

    private HealthComponent FindNearestTarget()
    {
        HealthComponent[] targets =
            FindObjectsByType<HealthComponent>(
                FindObjectsSortMode.None
            );

        HealthComponent nearestTarget = null;
        float nearestDistance = targetingRange;

        foreach (HealthComponent target in targets)
        {
            // Don't target ourselves.
            if (target.transform == transform)
                continue;

            float distance =
                Vector3.Distance(transform.position, target.transform.position);

            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestTarget = target;
            }
        }

        return nearestTarget;
    }
}