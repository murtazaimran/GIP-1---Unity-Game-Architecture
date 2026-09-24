using UnityEngine;

public class HealAbility : AbilityBase
{
    [SerializeField]
    private HealAbilityConfig config;

    private HealthComponent health;

    private void Awake()
    {
        health = GetComponentInParent<HealthComponent>();

        if (health == null)
        {
            Debug.LogError("HealAbility could not find a HealthComponent in the parent.");
        }
    }

    public void Use()
    {
        if (!CanUse())
            return;

        if (health == null || config == null)
            return;

        health.Heal(config.healAmount);

        StartCooldown(config.cooldown);
    }
}