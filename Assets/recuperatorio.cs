using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recuperatorio : MonoBehaviour
{
    public string gusto;
    public int cantidad;
    float precio = 500;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidad >= 250 && cantidad <= 3000)
        {

            if (gusto == "CHO" && cantidad == 250)
            {
                precio = 500 / 4;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "CHO" && cantidad == 500)
            {
                precio = 500 / 2;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "CHO" && cantidad == 1000)
            {
                precio = 500;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "DDL" && cantidad == 250)
            {
                precio = 500 / 4;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "DDL" && cantidad == 500)
            {
                precio = 500 / 2;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "DDL" && cantidad == 1000)
            {
                precio = 500;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "FRU" && cantidad == 250)
            {
                precio = (500 / 4) * 0.9f;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "FRU" && cantidad == 500)
            {
                precio = (500 / 2) * 0.9f;
                Debug.Log("El precio va a ser $" + precio);
            }
            if (gusto == "FRU" && cantidad == 1000)
            {
                precio = 500 * 0.9f;
                Debug.Log("El precio va a ser $" + precio);
            }
        }
        if (cantidad < 250 && cantidad > 3000)
        {
            Debug.Log("La cantidad debe ser mayor a 250 y menor a 3000");
        }
        if (gusto != "CHO" && gusto != "DDL" && gusto != "FRU")
        {
            Debug.Log("Poner un gusto valido");
        }

        // Update is called once per frame
        void Update()
     {
        
     }
   }
}
