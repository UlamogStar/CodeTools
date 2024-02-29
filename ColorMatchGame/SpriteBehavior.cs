using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]

public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        spriteRenderer.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        spriteRenderer.color = obj.currentColor.value;
    }
}

