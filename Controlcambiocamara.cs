using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlcambiocamara : MonoBehaviour
{
    public SceneController controladorescena; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other) // automatizar el cambio de camaras cuando choca con algo trigger
    {
        controladorescena.AsignarCamara(1, 10);
    }
}
