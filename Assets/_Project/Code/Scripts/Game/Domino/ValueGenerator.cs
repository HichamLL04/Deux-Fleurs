using System;
using UnityEngine;

public class ValueGenerator : MonoBehaviour
{
    private int endA;
    private int endB;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] tiles;


    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void SetValues(int a, int b)
    {
        endA = a;
        endB = b;
        ChangeSprite();
    }


    void ChangeSprite()
    {
        int low = Mathf.Min(endA, endB);
        int high = Mathf.Max(endA, endB);

        string name = $"Domino_{low}_{high}";
        Sprite seach = null;

        foreach (Sprite sprite in tiles)
        {
            if (sprite.name == name)
            {
                seach = sprite;
                break;
            }
        }

        if (seach != null)
        {
            spriteRenderer.sprite = seach;
            spriteRenderer.flipX = endA < endB;
        }
    }
}
