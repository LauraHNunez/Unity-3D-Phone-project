using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Controlador : MonoBehaviour
{
    public GameObject  player;
    Text txt;
    int seconds = 120;

    //X=71.4 Y=1.855423 Z=-1.3

    // Start is called before the first frame update
    void Start()
    {
        txt=gameObject.GetComponent<Text>();
       StartCoroutine("Timer");
    }//Start

    IEnumerator ENDGAME(){
     yield return new WaitForSeconds(4);
     Application.Quit();
    }//ENDGAME

    IEnumerator WINNER(){
     yield return new WaitForSeconds(4);
     Application.Quit();
    }//WINNER

    IEnumerator Timer(){
        yield return new WaitForSeconds(1);
        seconds = seconds-1;
        txt.text = "Time:"+seconds.ToString();


        if(seconds == 0){
            txt.text = "Game Over";
            StartCoroutine("ENDGAME");  
        }
       StartCoroutine("Timer");
    }//Timer

    // Update is called once per frame
    void Update()
    {
       Debug.Log(player.transform.position.x);
       float playerX = player.transform.position.x;
       float playerZ = player.transform.position.z;
       if (playerX <= 71.4 && playerZ <= -1.3){
            txt.text = "You have win";
            StartCoroutine("WINNER");  
       }
        //txt.text = Math.Max(0,  player.transform.position.x).ToString("0");
        // txt.text = "Hola qu tal";
    }//Update
}//Class
