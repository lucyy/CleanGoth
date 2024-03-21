using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesCapacitacion : MonoBehaviour
{
    
    public void Salir()
    {
        Application.Quit();
    }
    public void Atras()
    {
        SceneManager.LoadScene(0);
    }
   
}
