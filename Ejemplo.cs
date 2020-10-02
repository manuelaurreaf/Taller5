using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    private Coroutine recordatorioCoroutine;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            EjemploCiclo();
        else if (Input.GetKeyDown(KeyCode.D))
            recordatorioCoroutine = StartCoroutine(Recordatorio());
        else if (Input.GetKeyDown(KeyCode.W))
            //StopAllCoroutines();
            StopCoroutine(recordatorioCoroutine);
        else if (Input.GetKeyDown(KeyCode.T))
            StartCoroutine(RecordatorioRecurrente());

    }

    public void EjemploCiclo()
    {
        for (int i = 0; i < 100000; i++)
        {
            Debug.Log("prueba");
        }
    }


    IEnumerator Contador()
    {
        for (int i = 0; i < 100000; i++)
        {
            yield return null;
            Debug.Log("prueba1");
        }
    }

    IEnumerator Recordatorio()
    {
        Debug.Log("Agregando Recordatorio");
        yield return new WaitForSeconds(5f);
        Debug.Log("Hola! no olvides eso tan importante que tienes que hacer");

    }

    IEnumerator RecordatorioRecurrente()
    {
        while (true)
        {
            Debug.Log("Agregando Recordatorio recurrente");
            yield return new WaitForSeconds(6f);
            Debug.Log("Hola! no te voy dejar olvidar esa cosa");

            //yield return new WaitForSeconds(1f);
        }

    }


}
