using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    // Перенести name и color сюда!

    protected abstract void DisplayText();
    
    protected void SetMaterialColor(Color color)
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
