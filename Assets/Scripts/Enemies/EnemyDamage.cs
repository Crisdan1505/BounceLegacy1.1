using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float bounceForce = 8f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D playerRb =
                collision.gameObject.GetComponent<Rigidbody2D>();

            // Si el jugador cae encima del enemigo
            if (collision.transform.position.y >
                transform.position.y + 0.3f)
            {
                playerRb.linearVelocity = new Vector2(
                    playerRb.linearVelocity.x,
                    bounceForce
                );

                Destroy(gameObject);
            }
            else
            {
                collision.gameObject.transform.position =
                    Vector3.zero;
            }
        }
    }
}