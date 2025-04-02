using UnityEngine;

public class GunFollowCamera : MonoBehaviour
{
    public Transform cameraTransform; // Cámara en primera persona
    public Vector3 positionOffset; // Ajuste de posición para el "hombro"

    void LateUpdate()
    {
        // Mantener la rotación de la cámara
        transform.rotation = cameraTransform.rotation;
        
        // Ajustar la posición para que el pivote sea como un hombro
        transform.position = cameraTransform.position + cameraTransform.TransformDirection(positionOffset);
    }
}