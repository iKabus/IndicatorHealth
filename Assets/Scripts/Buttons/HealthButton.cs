using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class HealthButton : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected Health Health {  get { return _health; } }

    protected float Value = 10f;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(Clicked);
    }

    protected abstract void Clicked();
}
