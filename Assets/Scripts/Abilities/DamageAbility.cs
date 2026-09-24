using UnityEngine;

public class DamageAbility : AbilityBase
{
    private GameObject target;

    public void SetTarget(GameObject target)
    {
        this.target = target;
    }

    protected override void Execute()
    {
        if (target == null)
            return;

        if (target.TryGetComponent<IDamageable>(out var damageable))
        {
            damageable.TakeDamage(config.Damage);
        }
    }
}
