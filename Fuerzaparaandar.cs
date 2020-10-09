using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzaparaandar : MonoBehaviour
{
    // public int z = 0;
   // public GameObject personaje;
    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.right;
    
    public void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }
    public void caminemija()
    {
        
    }
   public void OnTriggerStay(Collider other)
    {
        // gameObject.SetActive(false);
        transform.eulerAngles = new Vector3(0, -90, 0);
    }

}
