using UnityEngine;

public abstract class HealthIndicator : MonoBehaviour
{
    protected Health health;

    protected virtual void Start()
    {
        health = FindAnyObjectByType<Health>();

        if ( health != null)
        {
            health.Changed += HealthChanged;
        }
    }

    protected virtual void OnDestroy()
    {
        if (health != null)
        {
            health.Changed -= HealthChanged;
        }
    }

    protected abstract void ChangeValue(float currentHealth, float maxHealth);

    private void HealthChanged(float currentHealth, float maxHealth)
    {
        ChangeValue(currentHealth, maxHealth);
    }
}
