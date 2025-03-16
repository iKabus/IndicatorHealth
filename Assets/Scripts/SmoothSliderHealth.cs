using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothSliderHealth : HealthIndicator
{
    private Slider _slider;

    private float _smoothSpeed = 0.1f;
    private float _targetValue;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetValue, _smoothSpeed * Time.deltaTime);
    }

    protected override void ChangeValue(float currentHealth, float maxHealth)
    {
        _targetValue = currentHealth / maxHealth;
    }
}
