using UnityEngine;

[CreateAssetMenu(
    fileName = "DamageAbilityConfig",
    menuName = "Abilities/Damage Ability Config"
)]
public class DamageAbilityConfig : ScriptableObject
{
    [Header("Damage")]
    [Min(0f)]
    public float damageAmount = 25f;

    [Header("Cooldown")]
    [Min(0f)]
    public float cooldown = 2f;
}