using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public GameObject pl;

    void Start()
    {

    }

    public void begin(){
      pl.SetActive(true);
      Destroy(this.gameObject);
    }
    void Update()
    {

    }
}
