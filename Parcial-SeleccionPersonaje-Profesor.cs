using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstudiarParcial : MonoBehaviour
{
    public List<ControladorPersonaje> listaPersonaje;
    public GameObject personajeActual;
    private int indexList;

    public Text descripcionPersonaje;
    public InputField nombrePersonaje;

    public Button nombreMio;
    public Text cambioNombre;

    private Animator animatorActual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LastPersonaje();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            NextPersonaje();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animatorActual.SetBool("CambioAnim", true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animatorActual.SetBool("CambioAnim", false);
        }
    }

    public void NextPersonaje()
    {
        indexList++;

        if (personajeActual != null) Destroy(personajeActual);

        indexList = indexList % listaPersonaje.Count;
        personajeActual = Instantiate(listaPersonaje[indexList].gameObject);
        

        descripcionPersonaje.text = listaPersonaje[indexList].descripcion;
        nombrePersonaje.text = listaPersonaje[indexList].descripcion;

        animatorActual = personajeActual.GetComponent<Animator>();
    }
    public void LastPersonaje()
    {
        indexList++;

        if (personajeActual != null) Destroy(personajeActual);

        indexList = indexList % listaPersonaje.Count;
        personajeActual = Instantiate(listaPersonaje[indexList].gameObject);

        descripcionPersonaje.text = listaPersonaje[indexList].descripcion;
        nombrePersonaje.text = listaPersonaje[indexList].descripcion;

        animatorActual = personajeActual.GetComponent<Animator>();
    }
    public void CambiarNombre()
    {
        cambioNombre.text = "Bienvenido " + nombrePersonaje.text;
    }
}
