using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    [SerializeField] private string _name;
    [SerializeField] private Color _color;

    public string Name { private set; get; }
    public Color Color { set { _color = value; } }

    protected override void DisplayText()
    {
        Debug.Log("Sphere");
        SetMaterialColor(_color);
    }
}
