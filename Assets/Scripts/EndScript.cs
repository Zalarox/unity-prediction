using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScript : MonoBehaviour {

    public GameObject ball;
    public Text endText;
    Rigidbody2D rb2d;
    public BallMover ballMoverScript;
    GameManager gameManager;

    void Start ()
    {
        rb2d = ball.GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        gameManager.LoadCurrent();
    }

    void OnTriggerEnter2D()
    {
        endText.gameObject.SetActive(true);
        rb2d.velocity = Vector2.zero;
        ballMoverScript.gameObject.SetActive(false);
        StartCoroutine(wait());
    }
}