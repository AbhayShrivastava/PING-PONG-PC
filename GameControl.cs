using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour {
    public int Score1;
   public int Score2;
    public Text ScoreP1;
    public Text ScoreP2;
    public Button Q;
 
	// Use this for initialization
	void Start () {
	              Score1=0;
                  Score2=0;
                  
                  
	}
	
	// Update is called once per frame
	void Update () {
        ScoreP1.text=""+Score1;
        ScoreP2.text=""+Score2;

        if (Input.GetKeyUp(KeyCode.Escape))
        {
           Q .gameObject.SetActive(true);
            if (Time.timeScale==0)
            {
                Time.timeScale=1;
               Q.gameObject.SetActive(false);
            }
            else 
            {
                Time.timeScale=0;
            }
        
        }
	
	}
    public void Exit()
    {
        Application.Quit();
    }
        

    }

  
    







    







