using UnityEngine;
using System.Collections;

public class Movement: MonoBehaviour {
    public float speed;
    Vector2 pos;
    public AudioSource sound;
	// Use this for initialization
	void Start () {
        pos = transform.position;
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () { 
      
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
       pos.y=Mathf.Clamp(pos.y, -4.0f, 2.8f);
        
        transform.position = pos;

	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == true)
        {

            sound.Play();


        }



    }
}
