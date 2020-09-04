using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject bola;
    public float fuerzay = 0;
    public float fuerzaz = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            /* if (Input.GetKey(KeyCode.Space))
             {
                 bola.transform.position += new Vector3(0, 50, 100);
                 Debug.Log("  w w w  ");
             }*/
            if (Input.GetKeyUp(KeyCode.Space))
            {
            GameObject bolanueva;
           
            bolanueva = Instantiate(bola, transform.position, Quaternion.identity);
            bolanueva.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzay, fuerzaz));
        }
            
    }

}
