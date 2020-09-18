using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SceneController : MonoBehaviour
{
    public CinemachineVirtualCamera camara1;
    public CinemachineVirtualCamera camara2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // revisando que con botones me cambie la camara de una a otra
        if (Input.GetKeyDown(KeyCode.Z))
        {
            AsignarCamara(10, 1);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            AsignarCamara(1, 10);
        }
    }
    public void AsignarCamara (int prioridad1, int prioridad2)
    {
        camara1.Priority = prioridad1;
        camara2.Priority =prioridad2;
    }
}
