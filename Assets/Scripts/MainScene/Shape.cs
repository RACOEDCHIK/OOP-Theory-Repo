using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private Color _color;
    [SerializeField] private TextMeshProUGUI _text;

    public string Name { private set { _name = value; } get => _name; }
    public Color Color { protected set { _color = value; } get => _color; }

    protected abstract void DisplayText();
    
    protected void SetText(string text)
    {
        _text.text = text;
    }

    protected void SetMaterialColor(Color color)
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
