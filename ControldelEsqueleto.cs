using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControldelEsqueleto : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("CaminaArriba", true);
            transform.position += new Vector3(0, 0.01f, 0);
            Debug.Log("Camina Arriba");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("CaminaIzquierda", true);
            transform.position += new Vector3(-0.01f, 0, 0);
            Debug.Log("Camina Izquierda");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            animator.SetBool("CaminaAbajo", true);
            transform.position += new Vector3(0, -0.01f, 0);
            Debug.Log("Camina Abajo");
        }
        else if (Input.GetKey(KeyCode.D))
        {

            animator.SetBool("CaminaDerecha", true);
            transform.position += new Vector3(0.01f, 0, 0);
            Debug.Log("Camina Derecha");
        }
        else
        {
            animator.SetBool("CaminaArriba", false);
            animator.SetBool("CaminaIzquierda", false);
            animator.SetBool("CaminaAbajo", false);
            animator.SetBool("CaminaDerecha", false);
        }
    }
}
