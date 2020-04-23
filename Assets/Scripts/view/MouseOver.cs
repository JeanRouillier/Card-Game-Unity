using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MouseOver : MonoBehaviour
{
    Color originalColor;
    TextMeshPro meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<TextMeshPro>();
        originalColor = meshRenderer.color;
    }
    void OnMouseOver()
    {
        meshRenderer.color = Color.red;
    }

    void OnMouseExit()
    {
        meshRenderer.color = originalColor;
    }
}
