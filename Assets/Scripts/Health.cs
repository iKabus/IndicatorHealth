using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxValue { private set; get; } = 100;
    public float CurrentValue { private set; get; }

    public event Action OnCharacterDied;

    private void Start()
    {
        CurrentValue = MaxValue;
    }

    public void TakeDamage(float damage)
    {
        CurrentValue -= damage;

        if (CurrentValue <= 0)
        {
            OnCharacterDied?.Invoke();
        }
    }

    public void Heal(float healValue)
    {
        CurrentValue += healValue;

        if (CurrentValue > MaxValue)
        {
            CurrentValue = MaxValue;
        }
    }
}
