using UnityEngine;
public class GameplayUI : MonoBehaviour
{
    [SerializeField] private HealthComponent playerHealth;

    private void OnEnable()
    {
        playerHealth.HealthChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        playerHealth.HealthChanged -= UpdateHealth;
    }

    private void UpdateHealth(float current, float max)
    {
        Debug.Log($"Health: {current}/{max}");
    }
}