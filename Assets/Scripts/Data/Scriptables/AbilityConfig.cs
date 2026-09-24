using UnityEngine;

[CreateAssetMenu(
    fileName = "AbilityConfig",
    menuName = "Exercise/Ability Config"
)]
public class AbilityConfig : ScriptableObject
{
    public string AbilityName = "Fireball";

    [Min(0)]
    public float Damage = 25f;

    [Min(0)]
    public float HealAmount = 0f;

    [Min(0)]
    public float Cooldown = 2f;
}