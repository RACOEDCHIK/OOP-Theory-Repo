using UnityEngine;

public class Cylinder : Shape
{
    protected override void DisplayText()
    {
        SetText("And I am a cylinder");
        SetMaterialColor(Color.blue);
    }
}
