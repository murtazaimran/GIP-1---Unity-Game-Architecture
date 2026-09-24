using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    private AbilityController abilityController;

    private void Awake()
    {
        abilityController = GetComponent<AbilityController>();

        if (abilityController == null)
        {
            Debug.LogError("PlayerInputHandler could not find AbilityController.");
        }
    }

    private void Update()
    {
        if (abilityController == null)
            return;

        // Damage
        if (Input.GetKeyDown(KeyCode.Space))
        {
            abilityController.UseDamageAbility();
        }

        // Heal
        if (Input.GetKeyDown(KeyCode.H))
        {
            abilityController.UseHealAbility();
        }
    }
}