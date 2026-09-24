using UnityEngine;

public abstract class AbilityBase : MonoBehaviour
{
    private float cooldownTimer;

    protected bool CanUse()
    {
        return cooldownTimer <= 0f;
    }

    protected void StartCooldown(float duration)
    {
        cooldownTimer = duration;
    }

    protected virtual void Update()
    {
        if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }
}