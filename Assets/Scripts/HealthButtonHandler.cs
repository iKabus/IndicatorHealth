using UnityEngine;

public class HealthButtonHandler : MonoBehaviour
{
    private Health _health;

    private float _value = 10f;

    private void Start()
    {
        _health = FindAnyObjectByType<Health>();
    }

    public void OnDamageButtonClicked()
    {
        _health?.TakeDamage(_value);
    }

    public void OnHealButtonClicked()
    {
        _health?.Heal(_value);
    }
}
