using UnityEngine;
public interface IAbility
{
    bool CanUse { get; }
    float RemainingCooldown { get; }

    void Use();
}