using UnityEngine;

[CreateAssetMenu(
    fileName = "HealthConfig",
    menuName = "Exercise/Health Config"
)]
public class HealthConfig : ScriptableObject
{
    [Min(1)]
    public float MaxHealth = 100f;
}