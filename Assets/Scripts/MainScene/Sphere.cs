using UnityEngine;

public class Sphere : Shape
{
    protected override void DisplayText()
    {
        SetText($"Hey, I am {Name}");
        SetMaterialColor(Color);
    }
}
