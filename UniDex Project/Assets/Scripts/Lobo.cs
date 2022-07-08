using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobo : MonoBehaviour
{
    public Animator animal;
    private int confanim;

    private void Start()
    {
        confanim = 0;
    }

    public void buttonAnimacion() {
        if (confanim == 0)
        {
            animal.Play("walk");
            confanim = 1;
        }else {
            if (confanim == 1)
            {
                animal.Play("Nada");
                confanim = 0;
            }
        }
    }
}
