using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScript : MonoBehaviour {

    public GameObject ball;
    public Text endText;
    Rigidbody2D rb2d;
    public BallMover ballMoverScript;

    void Start ()
    {
        rb2d = ball.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D()
    {
        endText.gameObject.SetActive(true);
        rb2d.velocity = Vector2.zero;
        ballMoverScript.gameObject.SetActive(false);
    }
}