using UnityEngine;

public class AbilityController : MonoBehaviour
{
    [Header("Abilities")]
    [SerializeField]
    private DamageAbility damageAbility;

    [SerializeField]
    private HealAbility healAbility;

    private HealthComponent currentTarget;

    private TargetingSystem targetingSystem;

    private void Awake()
    {
        targetingSystem = GetComponent<TargetingSystem>();

        if (targetingSystem == null)
        {
            Debug.LogError(
                "AbilityController could not find TargetingSystem."
            );
        }
    }

    public void SetTarget(HealthComponent target)
    {
        currentTarget = target;

        if (currentTarget != null)
        {
            Debug.Log(
                $"Target set to: {currentTarget.gameObject.name}"
            );
        }
    }

    public void ClearTarget()
    {
        currentTarget = null;
    }

    public void UseDamageAbility()
    {
        if (damageAbility == null)
        {
            Debug.LogError("DamageAbility has not been assigned.");
            return;
        }

        // Find the current target dynamically.
        if (targetingSystem != null)
        {
            targetingSystem.UpdateTarget();
        }

        if (currentTarget == null)
        {
            Debug.LogWarning("No target found.");
            return;
        }

        damageAbility.Use(currentTarget);
    }

    public void UseHealAbility()
    {
        if (healAbility == null)
        {
            Debug.LogError("HealAbility has not been assigned.");
            return;
        }

        healAbility.Use();
    }
}