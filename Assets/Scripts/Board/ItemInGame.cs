using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class ItemInGame : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;


#if UNITY_EDITOR
    private void OnValidate()
    {
        if (!spriteRenderer)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }
#endif

    public void SetSkinItem(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    public void SetSortingLayer(int value)
    {
        spriteRenderer.sortingOrder = value;
    }
}
