using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int sc = 0;
    public Text tx;
    public Text gotext;
    public GameObject button;

    void Start()
    {
        EventSystem.current.onGetPoint += GetPoint;
        EventSystem.current.onGameOver += gameOver;
    }

    void GetPoint()
    {
        sc++;
        tx.text = "Score: " + sc.ToString();
    }

    void gameOver(){
        gotext.text = "Game Over\nScore: " + sc.ToString();
        button.SetActive(true);
    }
}
