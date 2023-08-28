using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludoPersonalizado : MonoBehaviour
{
    [SerializeField]
    private string nombre = "Nombre Predeterminado";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            string saludo = "Hola, " + nombre + "!";
            Debug.Log(saludo);
        }
    }
}
