using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int boca = 2;
        int racing = 1;

        Debug.Log("quien clasifica?");

        if (boca > racing)
        {
            Debug.Log("Clasifica bokita señores");
        }
        else
        {
            Debug.Log("Maldita Sea");
        }
    }
    void Update()
    {
        
    }

}
