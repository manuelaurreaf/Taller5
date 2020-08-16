using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seleccion : MonoBehaviour
{

    private Animator animator;
    public GameObject sailorJ;
    public Text sjBio;
    public GameObject sailorV;
    public Text svBio;
    private Vector3 posPersonaje;
    private Vector3 posPersonajeEscondido;
    private int persNumerado = 1;
    private SpriteRenderer sailorJRender, sailorVRender;

    private void Awake()
    {
        posPersonaje = sailorJ.transform.position;
        posPersonajeEscondido = sailorV.transform.position;
        sailorJRender = sailorJ.GetComponent<SpriteRenderer>();
        sailorVRender = sailorV.GetComponent<SpriteRenderer>();
        svBio.gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }
    public void NextPersonaje()
    {
        switch (persNumerado)
        {
            case 1:                                                        //se apaga jupiter y se prende venus
                sailorJRender.enabled = false;
                sjBio.gameObject.SetActive(false); 
                sailorJ.transform.position = posPersonajeEscondido;
                sailorV.transform.position = posPersonaje;
                sailorVRender.enabled = true;
                svBio.gameObject.SetActive(true);
                persNumerado++;
              
                break;
            case 2:                                                      //se apaga venus y se prende jupiter
                sailorVRender.enabled = false;
                svBio.gameObject.SetActive(false);
                sailorV.transform.position = posPersonajeEscondido;
                sailorJ.transform.position = posPersonaje;
                sailorJRender.enabled = true;
                sjBio.gameObject.SetActive(true);
                persNumerado++;
             
                Reset();
                break;
            default:

                Reset();
                break;
        }
    }
    
    private void Reset()
    {
        if (persNumerado >= 2)
        {
            persNumerado = 1;
        }
    }
    
}
