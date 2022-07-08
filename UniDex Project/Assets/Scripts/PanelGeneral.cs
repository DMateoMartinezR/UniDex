using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGeneral : MonoBehaviour
{
    public AudioSource soundL;
    public AudioSource soundI;
    public AudioClip sonidoLobo;
    public AudioClip sonidoInfo;
    public GameObject paneldeinfo;
    public Animator animal;
    private float tiempo;
    private int confPanel;
    private int confsonido;
    private int anim;
    
    // Start is called before the first frame update
    void Start()
    {
        soundL.clip = sonidoLobo;
        soundI.clip = sonidoInfo;
        confsonido = 0;
        confPanel = 0;
        tiempo = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (anim == 1) {
            if (tiempo >= 0f)
            {
                tiempo -= Time.deltaTime;
                if (tiempo <= 0)
                {
                    animal.Play("Nada");
                    tiempo = 6f;
                    anim = 0;
                }
            }
        }
    }

    public void reproducir(){
        if (confsonido == 0)
        {
            soundL.Play();
            animal.Play("howl");
            anim = 1;
            confsonido = 1;
        }
        else {
            soundL.Stop();
            animal.Play("Nada");
            anim = 0;
            tiempo = 6f;
            confsonido = 0;
        }

    }

    public void desplegarinfo() {
        if (confPanel == 0)
        {
            paneldeinfo.SetActive(true);
            confPanel = 1;
            soundI.Play();
        }
        else {
            paneldeinfo.SetActive(false);
            confPanel = 0;
            soundI.Stop();
        }
    }
}
