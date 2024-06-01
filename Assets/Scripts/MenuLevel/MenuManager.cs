using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField]
    public GameObject menuPaneli;



    public void Start()
    {
        menuPaneli.GetComponent<CanvasGroup>().DOFade(1, 1f);
        menuPaneli.GetComponent<RectTransform>().DOScale(1, 1f);

    }

    public void LevelDisplayGo() // Level Secim Ekranýna geçmek için yazacagýmýz kodlar buradadýr.
    {
        SceneManager.LoadScene("LevelMenu");

    }
    public void Exit()
    {

        Application.Quit();

    }

}
