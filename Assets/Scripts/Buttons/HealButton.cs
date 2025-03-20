using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HealButton : HealthButton
{
    protected override void Clicked()
    {
        Health.Heal(Value);
    }
}
