using UnityEngine;
using System.Collections;

public class p2move : MonoBehaviour {

    public float speedp2;
    Vector2 p2pos;
    public AudioSource sound;
    
  
    // Use this for initialization
    void Start()
    {
      
        p2pos = transform.position;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        p2pos.y += (Input.GetAxisRaw("Mouse Y"));
        p2pos.y = Mathf.Clamp(p2pos.y, -4.0f, 2.8f);
        transform.position = p2pos;
        
       

      
    }

  
           
           
        

      
        
        





    
        

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == true)
        {

            sound.Play();


        }
    
    
    
    }
}
