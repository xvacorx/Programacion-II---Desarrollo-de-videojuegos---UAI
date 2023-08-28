using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    [SerializeField] private float numero1 = 0;
    [SerializeField] private float numero2 = 0;
    [SerializeField] private string operacion = "suma";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
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
                resultado = numero1 / numero2;
                break;
            default:
                Debug.LogError("Error: Operación no válida.");
                break;
        }

        return resultado;
    }
}
