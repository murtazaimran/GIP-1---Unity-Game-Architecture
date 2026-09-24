using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] private AbilityController abilityController;
    [SerializeField] private GameObject target;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            abilityController.SetTarget(target);
            abilityController.UseDamageAbility();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            abilityController.UseHealAbility();
        }
    }
}