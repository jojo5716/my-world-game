using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeywordWalk : MonoBehaviour {
    public float speed = 4f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        Vector3 movement = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + movement,
            speed * Time.deltaTime
        );
    }
}
