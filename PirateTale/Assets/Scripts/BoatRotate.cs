using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatRotate : MonoBehaviour
{
    // Velocidade da rotação em graus por segundo
    public float rotationSpeed = 120f;

    // Ângulo alvo de rotação
    private Quaternion targetRotation;

    // Flag para saber se a rotação deve ser aplicada
    private bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        // Definir a rotação inicial como o ângulo alvo
        targetRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // Se pressionar A, rotacionar 60 graus para a esquerda
        if (Input.GetKeyDown(KeyCode.A))
        {
            targetRotation = Quaternion.Euler(0f, transform.eulerAngles.y - 60f, 0f);
            isRotating = true;
        }
        // Se pressionar D, rotacionar 60 graus para a direita
        else if (Input.GetKeyDown(KeyCode.D))
        {
            targetRotation = Quaternion.Euler(0f, transform.eulerAngles.y + 60f, 0f);
            isRotating = true;
        }

        // Somente rotaciona o objeto se estiver rotacionando
        if (isRotating)
        {
            // Interpolar a rotação atual para a rotação alvo de maneira suave
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Parar a rotação quando atingir o alvo
            if (Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                isRotating = false;
            }
        }
    }
}
