using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothSliderHealth : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Slider _slider;

    private float _smoothSpeed = 0.1f;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _health.CurrentValue / _health.MaxValue, _smoothSpeed * Time.deltaTime);
    }
}
