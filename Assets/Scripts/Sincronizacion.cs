using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Sincronizacion : MonoBehaviour
{
    public Animator atrLimpiador;
    public Animator atrEsponja;
    public ParticleSystem spEspray;

    public GameObject goVentana;
    public GameObject goLimpiador;
    public GameObject goEsponja;
    public GameObject goMesa;
    public GameObject goMesaPeque;
    public GameObject goEspray;

    void Start()
    {
        goEspray.SetActive(false);
        atrLimpiador.enabled = false;
        atrEsponja.enabled = false;
        spEspray.Pause();
    }

  

    public void LlamarLimpiador()
    {
        atrLimpiador.enabled = true;
        
    }
    public void DetenerLimpiador()
    {
        atrLimpiador.enabled = false;

    }
    public void LlamarEsponja()
    {
        atrEsponja.enabled = true;

    }
    public void DetenerEsponja()
    {
        atrEsponja.enabled = false;

    }
    public void LlamarEspray()
    {
        goEspray.SetActive(true);
        spEspray.Play();

    }
    public void DetenerEspray()
    {
        spEspray.Stop();


    }

    public void DesaparecerObjetos()
    {
        goVentana.SetActive(false);
        goLimpiador.SetActive(false);
        goEsponja.SetActive(false);
        goMesa.SetActive(false);
        goMesaPeque.SetActive(false);
        goEspray.SetActive(false);


    }
}
