using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player player;
    private Rigidbody2D _RB;
    public SpriteRenderer _SR;
    string _colour = "red";
    private Touch tch;
    private AudioSource _AS;

    public Color colourBlue;
  	public Color colourYellow;
  	public Color colourRed;
  	public Color colourPurple;

    public float jumpVel = 10f;

    void Start()
    {
        player = this;
        _RB = gameObject.GetComponent<Rigidbody2D>();
        _SR.color = colourRed;
        _AS = gameObject.GetComponent<AudioSource>();
        EventSystem.current.onGameOver += gameOver;
    }

    void Update()
    {
        if (Input.GetKeyDown("space") || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began ))
        {
            _RB.velocity = Vector2.up * jumpVel;
            _AS.Play();
        }
        if (transform.position.y < Camera.main.transform.position.y - 10)
        {
            EventSystem.current.gameOver();
        }
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.tag == "Point"){
          EventSystem.current.getPoint();
          Destroy(collision.gameObject);
          return;
        }

        if(collision.tag == "ColourChange"){
          SetRandomColor();
          Destroy(collision.gameObject);
          return;
        }

        if(collision.tag != _colour){
          EventSystem.current.gameOver();
        }
    }

    void SetRandomColor ()
	  {
		    int index = Random.Range(0, 4);

		    switch (index)
		    {
        			case 0:
        				_colour = "blue";
        				_SR.color = colourBlue;
        				break;
        			case 1:
        				_colour = "yellow";
        				_SR.color = colourYellow;
        				break;
        			case 2:
        				_colour = "red";
        				_SR.color = colourRed;
        				break;
        			case 3:
        				_colour = "purple";
        				_SR.color = colourPurple;
        				break;
		    }
	  }

    void gameOver(){
        Destroy(_RB.gameObject);
    }

    void onDestroy(){
        EventSystem.current.onGameOver -= gameOver;
    }
}
