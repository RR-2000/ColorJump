using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform follow;

    void Update()
    {
        if(follow == null){
          return;
        }
        if(follow.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, follow.position.y, transform.position.z);
        }
    }
}
