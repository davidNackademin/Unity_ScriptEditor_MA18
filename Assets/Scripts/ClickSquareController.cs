using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ClickSquareController : MonoBehaviour
{

    [HideInInspector]
    public int points = 0;

    public List<Color> colors;


    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        SetRandomColor();
    }


    private void OnMouseDown()
    {
        points++;
        SetRandomColor();
    }


    void SetRandomColor()
    {
        Color newColor = spriteRenderer.color;
        while (newColor == spriteRenderer.color)
        {
            newColor = colors[Random.Range(0, colors.Count)];
        }

        spriteRenderer.color = newColor;
    }


}
