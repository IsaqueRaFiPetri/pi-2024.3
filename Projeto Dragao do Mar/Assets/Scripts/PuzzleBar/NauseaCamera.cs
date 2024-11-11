using UnityEngine;

public class NauseaCamera : MonoBehaviour
{
    public float positionAmplitude = 0.1f;  // Intensidade do movimento da posição
    public float rotationAmplitude = 2.0f;  // Intensidade do movimento de rotação
    public float frequency = 1.0f;          // Frequência do movimento (velocidade)
    public BarController controller;

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        // Armazena a posição e rotação inicial da câmera
        initialPosition = transform.localPosition;
        initialRotation = transform.localRotation;
    }

    void Update()
    {
        if(controller.isPuzzleActive.Equals(true))
        {
            // Movimento de oscilação na posição da câmera
            float positionOffsetX = Mathf.Sin(Time.time * frequency) * positionAmplitude;
            float positionOffsetY = Mathf.Cos(Time.time * frequency * 0.5f) * positionAmplitude;
            transform.localPosition = initialPosition + new Vector3(positionOffsetX, positionOffsetY, 0);

            // Movimento de oscilação na rotação da câmera
            float rotationOffsetX = Mathf.Sin(Time.time * frequency) * rotationAmplitude;
            float rotationOffsetY = Mathf.Cos(Time.time * frequency * 0.5f) * rotationAmplitude;
            transform.localRotation = initialRotation * Quaternion.Euler(rotationOffsetX, rotationOffsetY, 0);
        }
        if (controller.isPuzzleActive.Equals(false))
        {
            initialPosition.y = .75f;
            initialRotation.y = 0;
        }
    }
}