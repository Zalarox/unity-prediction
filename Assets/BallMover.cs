using UnityEngine;
using System.Collections;

public class BallMover : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float speed = 2f;
    Vector2 dir = Vector2.right;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();    
	}
	
	void Update () {
        rb2d.velocity = dir * speed * Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.tag)
        {
            case "Left": dir = Vector2.left;  break;
            case "Right": dir = Vector2.right;  break;
            case "Top": dir = Vector2.up;  break;
            case "Down": dir = Vector2.down; break;
            default: break;
        }
    }
}
