using UnityEngine;

[CreateAssetMenu(
    fileName = "HealAbilityConfig",
    menuName = "Abilities/Heal Ability Config"
)]
public class HealAbilityConfig : ScriptableObject
{
    [Header("Healing")]
    [Min(0f)]
    public float healAmount = 25f;

    [Header("Cooldown")]
    [Min(0f)]
    public float cooldown = 5f;
}