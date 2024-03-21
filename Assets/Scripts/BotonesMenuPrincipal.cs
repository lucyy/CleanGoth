using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BotonesMenuPrincipal : MonoBehaviour
{

    
    public Image imgImagenFondo;
    public Text txtTexto1;
    public Text txtTexto2;
    public Image imgLogo;
    public Button btnContinuar;
    public Button btnSalir;
    public Button btnInfo;

    public Image imgImagenIn;
    public Text txtTextoInfo;
    public Button btnSalirInfo;
    public Button btnAtras;

    public void BotonInfo()
    {

        imgImagenIn.gameObject.SetActive(true);
        txtTextoInfo.gameObject.SetActive(true);
        btnSalirInfo.gameObject.SetActive(true);
        btnAtras.gameObject.SetActive(true);

        imgImagenFondo.gameObject.SetActive(false);
        txtTexto1.gameObject.SetActive(false);
        txtTexto2.gameObject.SetActive(false);
        imgLogo.gameObject.SetActive(false);
        btnContinuar.gameObject.SetActive(false);
        btnSalir.gameObject.SetActive(false);
        btnInfo.gameObject.SetActive(false);
  
     
    }

    public void BotonAtras()
    {
        imgImagenFondo.gameObject.SetActive(true);
        txtTexto1.gameObject.SetActive(true);
        txtTexto2.gameObject.SetActive(true);
        imgLogo.gameObject.SetActive(true);
        btnContinuar.gameObject.SetActive(true);
        btnSalir.gameObject.SetActive(true);
        btnInfo.gameObject.SetActive(true);

        imgImagenIn.gameObject.SetActive(false);
        txtTextoInfo.gameObject.SetActive(false);
        btnSalirInfo.gameObject.SetActive(false);
        btnAtras.gameObject.SetActive(false);
    }
    public void BotonSalir()
    {
        Application.Quit();
    }

    public void BotonContinuar()
    {
        SceneManager.LoadScene(1);
    }
    }
