using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeCondicional: MonoBehaviour
{
    [SerializeField] private int edad = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string vejez = ConsultarEdad();
            Debug.Log("Hola " + vejez);
        }
    }

    string ConsultarEdad()
    {
        string resultado = " ";

        switch (edad)
        {
            case <18:
                resultado = "Joven";
                break;
            case <30:
                resultado = "Adulto";
                break;
            case >30:
                resultado = "Viejo";
                break;
        }

        return resultado;
    }
}
