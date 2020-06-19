using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public static EventSystem current;

    void Awake()
    {
        current = this;
    }

    public event Action onGetPoint;
    public void getPoint(){
        if(onGetPoint != null){
            onGetPoint();
        }
    }

    public event Action onGameOver;
    public void gameOver(){
      if(onGameOver != null){
        onGameOver();
      }
    }

    public event Action onTap;
    public void tap(){
      if(onTap != null){
        onTap();
      }
    }
}
