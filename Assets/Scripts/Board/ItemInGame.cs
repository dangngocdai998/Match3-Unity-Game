using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]
public class ItemInGame : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    [SerializeField] Rigidbody2D rb2;


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

    public void Explode()
    {
        rb2.bodyType = RigidbodyType2D.Dynamic;
        rb2.AddForce(new Vector2(Random.Range(-0.5f, 0.5f), 1) * Random.Range(3f, 9f), ForceMode2D.Impulse);
        rb2.AddTorque(Random.Range(-30f, 30f));

        Invoke("DestroyItem", 3);
    }

    void DestroyItem()
    {
        GameObject.Destroy(this.gameObject);
    }
}
