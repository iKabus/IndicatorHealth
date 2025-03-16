using UnityEngine;

public class HealthButtonHandler : MonoBehaviour
{
    [SerializeField] private Health _health;

    private float _value = 10f;

    public void OnDamageButtonClicked()
    {
        _health.TakeDamage(_value);
    }

    public void OnHealButtonClicked()
    {
        _health.Heal(_value);
    }
}
