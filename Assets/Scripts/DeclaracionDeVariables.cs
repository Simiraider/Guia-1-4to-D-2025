using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{

    //declaro variables
    int edadUsuario;
    float altura;
    string domicilio;
    bool estaAprobado;

    // Start is called before the first frame update
    void Start()
    {
        //inicializo los valores de las funciones
        edadUsuario = 15;
        altura = 1.75;
        domicilio = "Paroissen 3048";
        estaAprobado = true;
        
        //aparecen en la consola
        debug.log(edadUsuario);
        debug.log(altura);
        debug.log(domicilio);
        debug.log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
