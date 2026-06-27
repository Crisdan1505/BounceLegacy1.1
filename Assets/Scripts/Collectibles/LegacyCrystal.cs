using UnityEngine;

public class LegacyCrystal : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.AddCrystal(value);

            Destroy(gameObject);
        }
    }
}