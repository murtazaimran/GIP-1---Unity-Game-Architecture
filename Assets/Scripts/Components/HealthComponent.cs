using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour, IDamageable
{
    [SerializeField] private HealthConfig config;

    public float CurrentHealth { get; private set; }
    public float MaxHealth => config.MaxHealth;

    public bool IsAlive => CurrentHealth > 0;

    public event Action<float, float> HealthChanged;    // event for health change  
    
    public event Action Died;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(float amount)
    {
        if (!IsAlive || amount <= 0)
            return;

        CurrentHealth = Mathf.Max(0, CurrentHealth - amount);

        HealthChanged?.Invoke(CurrentHealth, MaxHealth);

        if (CurrentHealth <= 0)
        {
            Died?.Invoke();
        }
    }

    public void Heal(float amount)
    {
        if (!IsAlive || amount <= 0)
            return;

        CurrentHealth = Mathf.Min(MaxHealth, CurrentHealth + amount);

        HealthChanged?.Invoke(CurrentHealth, MaxHealth);
    }
}