using UnityEngine;

public class AbilityController : MonoBehaviour
{
    [SerializeField] private DamageAbility damageAbility;
    [SerializeField] private HealAbility healAbility;

    private GameObject currentTarget;

    public void SetTarget(GameObject target)
    {
        currentTarget = target;
    }

    public void UseDamageAbility()
    {
        if (currentTarget == null)
            return;

        damageAbility.SetTarget(currentTarget);
        damageAbility.Use();
    }

    public void UseHealAbility()
    {
        healAbility.Use();
    }
}