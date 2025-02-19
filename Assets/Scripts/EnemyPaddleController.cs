using UnityEngine;

public class EnemyPaddleController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 3f;
    private GameObject ball;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball"); // Encontra o objeto da bola na cena}
    }
    void Update()
    {
        if (ball != null)
        {
            float targetY = Mathf.Clamp(ball.transform.position.y, -4.5f, 4.5f);
            Vector2 targetposition = new Vector2(transform.position.x, targetY);
            transform.position = Vector2.MoveTowards(transform.position, targetposition, Time.deltaTime * speed);
        }
    }
}
