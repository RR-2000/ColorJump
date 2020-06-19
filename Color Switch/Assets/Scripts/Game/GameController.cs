using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] list;
    private Transform t;
    double prevObs;

    void Start()
    {
      prevObs = 8;
      t = Camera.main.transform;
    }

    void newObs(double y){
      int x = Random.Range(0, 6);
      if(x == 0 || x == 5){
        y -= 2.5;
        prevObs -= 5;
      }
      if(x == 3){
        y += 1.5;
        prevObs = y + 1.5;
      }
      if(x == 4){
        y += 1;
        prevObs = y + 1;
      }
      Instantiate(list[x], new Vector3(0, (float)y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
      if(prevObs - t.position.y <= 3){
        prevObs += 5;
        newObs(prevObs);
      }
    }


}
