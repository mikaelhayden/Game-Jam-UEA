using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

//Script do menu do game, o menu conta com o bot�o Play, settings e Info
//O play inicia a cena do game principal 
//O bot�o settings abre uma tela para as configura��es do game
//o bot�o info abre uma tela para as informa��es do desenvolvedor e agradecimentos

public class menu : MonoBehaviour
{
    public GameObject inforObj;
    public GameObject menuInicial;
    public GameObject playButton;
    public GameObject voltarInfoButton;


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            //caso o jogador pressione esc e esteja na tela de info ele volta pra tela principal
            inforObj.SetActive(false);      //active de info fica false e vari�vel para saber se est� na tela de info fica false
            menuInicial.SetActive(true);
        }

    }

    private void Start()
    {
        Cursor.visible = true;
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void info()
    {
        inforObj.SetActive(true);
        menuInicial.SetActive(false);

        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);
        //set a new object
        EventSystem.current.SetSelectedGameObject(voltarInfoButton);
    }


    public void voltar()    //Volta todas as telas se estiver em alguma tela, ir� voltar
    {
        inforObj.SetActive(false);
        menuInicial.SetActive(true); ;            //Pausa o game para n�o entrar em duas telas ao mesmo tempo

        EventSystem.current.SetSelectedGameObject(null);

        //set a new object
        EventSystem.current.SetSelectedGameObject(playButton);

    }

    public void sair()
    {
        Application.Quit();
    }
}
