using UnityEngine;
using System.Collections;

public class ballMove : MonoBehaviour {
    private Rigidbody2D rb;
    public GameControl Gc;
    public float speed=3f;
    private AudioSource am;
    
	// Use this for initialization
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<AudioSource>();


    }
    
    
    void Start () {
	 rb.velocity = new Vector2(speed,speed);
	}
	
	// Update is called once per frame
	void Update () {


       
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player2goal")
        {
            Gc.Score2 += 1;
            am.Play();
        }

    
 
        if (col.gameObject.tag == "GameController")
        {
            am.Play();
            Gc.Score1 += 1;
        }
      


    }



   
}
