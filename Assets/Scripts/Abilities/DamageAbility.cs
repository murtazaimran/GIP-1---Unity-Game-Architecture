using UnityEngine;

public class DamageAbility : AbilityBase
{
    [SerializeField]
    private DamageAbilityConfig config;

    public void Use(HealthComponent target)
    {
        if (!CanUse())
            return;

        if (target == null)
        {
            Debug.LogWarning("DamageAbility has no target.");
            return;
        }

        if (config == null)
        {
            Debug.LogError("DamageAbilityConfig has not been assigned.");
            return;
        }

        target.TakeDamage(config.damageAmount);

        StartCooldown(config.cooldown);
    }
}