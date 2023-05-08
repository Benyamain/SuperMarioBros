using System.Collections;
using UnityEngine;

public class BlockHit : MonoBehaviour
{
    // Block can be hit over and over again
    public int maxHits = -1;
    public Sprite emptyBlock;
    private bool animating;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!animating && collision.gameObject.CompareTag("Player"))
        {
            // If Mario hit the block in the same direction
            if (collision.transform.DotTest(transform, Vector2.up))
            {
                Hit();
            }
        }
    }

    private void Hit()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        maxHits--;

        if (maxHits == 0)
        {
            spriteRenderer.sprite = emptyBlock;
        }

        StartCoroutine(Animate());
    }

    private IEnumerator Animate()
    {
        animating = true;

        Vector3 restingPosition = transform.localPosition;
        Vector3 animatedPosition = restingPosition + Vector3.up * 0.5f;

        animating = false;
    }
}
