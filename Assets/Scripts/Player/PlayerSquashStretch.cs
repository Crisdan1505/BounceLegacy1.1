using UnityEngine;

public class PlayerSquashStretch : MonoBehaviour
{
    private Rigidbody2D rb;

    public float stretchAmount = 1.2f;
    public float squashAmount = 0.8f;
    public float smoothSpeed = 8f;

    private Vector3 originalScale;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalScale = transform.localScale;
    }

    void Update()
    {
        float velocityY = rb.linearVelocity.y;

        Vector3 targetScale;

        if (velocityY > 0.1f)
        {
            targetScale = new Vector3(
                squashAmount,
                stretchAmount,
                1f
            );
        }
        else if (velocityY < -0.1f)
        {
            targetScale = new Vector3(
                stretchAmount,
                squashAmount,
                1f
            );
        }
        else
        {
            targetScale = originalScale;
        }

        transform.localScale = Vector3.Lerp(
            transform.localScale,
            targetScale,
            smoothSpeed * Time.deltaTime
        );
    }
}