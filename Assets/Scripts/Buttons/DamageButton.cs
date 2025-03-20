using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DamageButton : HealthButton
{
    protected override void Clicked()
    {
        Health.TakeDamage(Value);
    }
}
