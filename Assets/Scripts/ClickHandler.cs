using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {

    GameObject ball;
    Vector2 ballPos;
    BallMover mover;
    SpriteRenderer sr;

    void Start()
    {
        ball = GameObject.Find("Ball");
        mover = ball.GetComponent<BallMover>();
        sr = ball.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        ballPos = new Vector2(ball.transform.position.x, ball.transform.position.y);
        Vector2 pixelPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(pixelPos);
        Vector2 distance = ballPos - mousePos;
        Debug.Log("dist: " + distance.magnitude);
        mover.speed = 0;
        sr.sortingLayerName = "ClosedPipe";
    }
}
