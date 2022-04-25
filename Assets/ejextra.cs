using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejextra : MonoBehaviour
{
    public int años;
    public float altura;

    // Start is called before the first frame update
    void Start()
    {
        if(años < 1)
        {
            Debug.Log("error la edad debe ser mayor a 1");
        }
        else
    {

        
        if(años > 13 && altura > 1.2)
      {
            Debug.Log("acceso permitido");
      }
        
        else
      {
            Debug.Log("acceso denegado");
        }
    }
        if (altura < 0)
      {
            Debug.Log("Error, la altura debe ser positiva");
      }
        else
        {


            if (años > 13 && altura > 1.2)
            {
                Debug.Log("acceso permitido");
            }

            else
            {
                Debug.Log("acceso denegado");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
