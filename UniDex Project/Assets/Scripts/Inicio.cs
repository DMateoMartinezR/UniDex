using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicio : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelFun;
    public GameObject cfuncional;
    
    // Start is called before the first frame update
    void Start()
    {
        panelInicio.SetActive(true);
        panelFun.SetActive(false);
        cfuncional.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void empezar() {
        panelInicio.SetActive(false);
        panelFun.SetActive(true);
        cfuncional.SetActive(true);
    }
}
