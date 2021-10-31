using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeywordWalk : MonoBehaviour {
    public float speed = 4f;
    Animator anim;
    Rigidbody2D rb2d;
    Vector2 mov;

    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        // Set animation player
        anim.SetFloat("movX", mov.x);
        anim.SetFloat("movY", mov.y);
    }

    void FixedUpdate() {
        // Move chatacter with physics.
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
}
