using UnityEngine;

class CharacterAnimator : MonoBehaviour {
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start() {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(speed));

        Flip(speed);
    }

    void Flip(float direction) {
        if (direction > 0) {
            spriteRenderer.flipX = false;
        }
        else if (direction < 0) {
            spriteRenderer.flipX = true;
        }
    }
}
