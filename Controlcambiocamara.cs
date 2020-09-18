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
    public void OnTriggerEnter(Collider other)
    {
        controladorescena.AsignarCamara(1, 10);
    }
}
