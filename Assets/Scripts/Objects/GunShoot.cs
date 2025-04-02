using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // El prefab de la bala
    public Transform firePoint; // El punto desde donde sale la bala
    public float bulletSpeed = 20f;
    public float destroyTime = 2f; // Tiempo antes de que se destruya la bala

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Disparo al hacer click
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instancia una nueva bala
        GameObject bulletClone = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        // Agregarle velocidad
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }

        // Destruir solo el clon después del tiempo indicado
        Destroy(bulletClone, destroyTime);
    }
}