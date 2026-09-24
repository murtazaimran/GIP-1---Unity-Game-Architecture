using UnityEngine;

public class AbilityController : MonoBehaviour
{
    [Header("Abilities")]
    [SerializeField]
    private DamageAbility damageAbility;

    [SerializeField]
    private HealAbility healAbility;

    private HealthComponent currentTarget;

    public void SetTarget(HealthComponent target)
    {
        currentTarget = target;

        if (currentTarget != null)
        {
            Debug.Log($"Target set to: {currentTarget.gameObject.name}");
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

        if (currentTarget == null)
        {
            Debug.LogWarning("No target selected.");
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