using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miprimerscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int nano = 33;
        int taylor = 13;
        int boca = 7;

        nano = Divorcio(taylor, nano);

        EscribirAConsola(nano);

        EscribirAConsola(taylor);

        EscribirAConsola(boca);

    }
    void EscribirAConsola(int mistica)
    {
        Debug.Log(mistica);

    }

    int Divorcio(int rubia, int gallego)
    {
        int NanoYaNoEsSwiftie = rubia - gallego;
        return NanoYaNoEsSwiftie;

    }

    

    
  }
