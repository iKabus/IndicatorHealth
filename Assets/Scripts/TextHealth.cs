using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextHealth : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = $"{_health.CurrentValue}/{_health.MaxValue}";
    }
}
