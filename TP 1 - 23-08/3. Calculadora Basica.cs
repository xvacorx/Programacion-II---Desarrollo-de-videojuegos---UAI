using UnityEngine;

public class Calculadora : MonoBehaviour
{
    [SerializeField]
    private float numero1 = 0;

    [SerializeField]
    private float numero2 = 0;

    [SerializeField]
    private string operacion = "suma"; // Valor predeterminado: suma

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Realizar la operación y mostrar el resultado
            float resultado = RealizarOperacion();
            Debug.Log("El resultado es: " + resultado);
        }
    }

    float RealizarOperacion()
    {
        float resultado = 0f;

        switch (operacion.ToLower())
        {
            case "suma":
                resultado = numero1 + numero2;
                break;
            case "resta":
                resultado = numero1 - numero2;
                break;
            case "multiplicacion":
                resultado = numero1 * numero2;
                break;
            case "division":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Debug.LogError("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Debug.LogError("Error: Operación no válida.");
                break;
        }

        return resultado;
    }
}
