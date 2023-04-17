using UnityEngine;

public class Cube : Shape
{
    protected override void DisplayText()
    {
        SetText("Hello World!");
        SetMaterialColor(Color);
    }
}
