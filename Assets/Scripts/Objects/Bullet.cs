using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float destroyDelay = 3f; // Tiempo antes de destruirse si no impacta nada

    void Start()
    {
        Destroy(gameObject, destroyDelay); // Destruir la bala tras un tiempo
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject); // Destruir la bala al impactar con una pared o enemigo
        }
    }
}