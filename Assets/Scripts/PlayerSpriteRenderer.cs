using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteRenderer : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PlayerMovement movement;
    public Sprite idle, jump, slide;
    public AnimatedSprite run;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponentInParent<PlayerMovement>();
    }

    private void OnEnable()
    {
        spriteRenderer.enabled = true;
    }

    private void OnDisable()
    {
        spriteRenderer.enabled = false;
    }

    private void LateUpdate()
    {
        run.enabled = movement.running;

        // Order of this condition does matter ; overrides the running script
        if (movement.jumping)
        {
            spriteRenderer.sprite = jump;
        } else if (movement.sliding)
        {
            spriteRenderer.sprite = slide;
        } else if (!movement.running)
        {
            spriteRenderer.sprite = idle;
        }
    }
}
