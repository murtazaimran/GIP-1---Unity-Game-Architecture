using UnityEngine;

public class HealAbility : AbilityBase
{
    [SerializeField] private HealthComponent ownerHealth;

    protected override void Execute()
    {
        ownerHealth.Heal(config.HealAmount);
    }
}
