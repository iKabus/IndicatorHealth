using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxValue { private set; get; } = 100;
    public float CurrentValue { private set; get; }

    public event Action<float, float> Changed;

    private void Start()
    {
        CurrentValue = MaxValue;

        Changed?.Invoke(CurrentValue, MaxValue);
    }

    public void TakeDamage(float damage)
    {
        CurrentValue -= damage;

        if (CurrentValue <= 0)
        {
            CurrentValue = 0;
        }

        Changed?.Invoke(CurrentValue, MaxValue);
    }

    public void Heal(float healValue)
    {
        CurrentValue += healValue;

        if (CurrentValue > MaxValue)
        {
            CurrentValue = MaxValue;
        }

        Changed?.Invoke(CurrentValue, MaxValue);
    }
}
