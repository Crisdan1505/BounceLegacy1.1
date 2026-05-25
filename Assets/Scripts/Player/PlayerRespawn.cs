using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 startPosition;

    public float fallLimit = -8f;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.y < fallLimit)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = startPosition;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}