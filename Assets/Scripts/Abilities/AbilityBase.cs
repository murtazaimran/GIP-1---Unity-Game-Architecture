using UnityEngine;

public abstract class AbilityBase : MonoBehaviour, IAbility
{
    [SerializeField] protected AbilityConfig config;

    private float nextAvailableTime;

    public bool CanUse => Time.time >= nextAvailableTime;

    public float RemainingCooldown =>
        Mathf.Max(0f, nextAvailableTime - Time.time);

    public void Use()
    {
        if (!CanUse)
            return;

        Execute();

        nextAvailableTime = Time.time + config.Cooldown;
    }

    protected abstract void Execute();
}
