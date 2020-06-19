using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    void Update()
    {
      if(Player.player == null){
        return;
      }
      if(transform.position.y < Player.player.transform.position.y - 10){
        Destroy(this.gameObject);
      }
    }
}
