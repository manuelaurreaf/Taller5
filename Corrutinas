using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejemplo2 : MonoBehaviour
{
    public Text TextoUsado;

    public string textoString;
    public string textoActual;
    public float segundos = 1f;

    public List<string> textoCharla;
    public int posicionCharlaActual = 0;

    private bool estoyEscribiendo = false;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A)) //sale el texto de una 
            TextoUsado.text = textoString;
        else if (Input.GetKeyUp(KeyCode.S))
            StartCoroutine(CargarTexto(textoString));
        else if (Input.GetKeyUp(KeyCode.D))
            StartCoroutine(Conversacion());
        else if (Input.GetKeyUp(KeyCode.F))
            StartCoroutine(Conversacion2());
        else if (Input.GetKeyUp(KeyCode.Space))
            StartCoroutine(Conversacion3());

    }

    private IEnumerator CargarTexto(string textoDeseado)
    {
        textoActual = string.Empty;
        for (int i = 0; i < textoDeseado.Length; i++)
        {
            //textoActual = textoActual + textoDeseado[i];
            textoActual += textoDeseado[i];

            TextoUsado.text = textoActual;
            yield return new WaitForSeconds(segundos);
        }

    }

    private IEnumerator Conversacion() //se borra el texto anterior
    {
        //foreach (string charla in textoCharla)
        for (int e = 0; e < textoCharla.Count; e++)
        {
            string textoDeseado = textoCharla[e];
            textoActual = string.Empty;
            for (int i = 0; i < textoDeseado.Length; i++)
            {
                //textoActual = textoActual + textoDeseado[i];
                textoActual += textoDeseado[i];

                TextoUsado.text = textoActual;
                yield return new WaitForSeconds(segundos);
            }

            yield return new WaitForSeconds(1f);

        }

    }

    private IEnumerator Conversacion2()// sale el texto con enter entre dialogo
    {
        textoActual = string.Empty;
        //foreach (string charla in textoCharla)
        for (int e = 0; e < textoCharla.Count; e++)
        {
            string textoDeseado = textoCharla[e];
            for (int i = 0; i < textoDeseado.Length; i++)
            {
                //textoActual = textoActual + textoDeseado[i];
                textoActual += textoDeseado[i];

                TextoUsado.text = textoActual;
                yield return new WaitForSeconds(segundos);
            }

            yield return new WaitForSeconds(1f);
            textoActual += "\n";
        }

    }

    private IEnumerator Conversacion3() //sale el texto con enter y con tener que undir botones para siguiente
    {
        if (!estoyEscribiendo)
        {
            estoyEscribiendo = true;
            string textoDeseado = textoCharla[posicionCharlaActual];
            for (int i = 0; i < textoDeseado.Length; i++)
            {
                //textoActual = textoActual + textoDeseado[i];
                textoActual += textoDeseado[i];

                TextoUsado.text = textoActual;
                yield return new WaitForSeconds(segundos);
            }

            posicionCharlaActual++;
            if (posicionCharlaActual == textoCharla.Count)
                posicionCharlaActual = 0;

            textoActual += "\n";
            estoyEscribiendo = false;
        }

    }
}
