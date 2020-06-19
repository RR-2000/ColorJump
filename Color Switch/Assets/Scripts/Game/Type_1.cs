using UnityEngine;

public class Type_1 : MonoBehaviour
{
    public float rotSpeed = 100f;
    void Start(){
      EventSystem.current.onGameOver += gameOver;
    }
    void Update()
    {
        transform.Rotate(0f, 0f, rotSpeed * Time.deltaTime);
    }

    void gameOver(){
      rotSpeed = 0;
    }
}
