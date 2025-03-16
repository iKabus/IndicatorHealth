using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHealth : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        _slider.value = _health.CurrentValue / _health.MaxValue;
    }
}
