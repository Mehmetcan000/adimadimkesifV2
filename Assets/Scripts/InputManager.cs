using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    GameObject Player;
    GameManager gameManager;

    public string ad;


    private void Awake()
    {
        gameManager =Object.FindObjectOfType<GameManager>(); 
        Player = GameObject.Find("Player");
    }
    public void OnMouseDown()
    {
        if(!gameManager.sorucevaplansinmi)
        {
            return;
        }
        if(this.transform.position.z>Player.transform.position.z && this.transform.position.z<Player.transform.position.z+2)
        {
            Vector3 mousePos = this.transform.position;

            Player.GetComponent<OyuncuHareketManager>().HareketEt(mousePos, 0.2f);
            gameManager.SonucuKontrolEt(ad);
            gameManager.sorucevaplansinmi = false;

        }    
    }
}
