using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public int Score = 0;
    public int Vie = 8;
	public Text ScoreDisplay;
    public Text life;
    
    


    // Use this for initialization
    void Start () {
        Vie = 8;
	}
	
	// Update is called once per frame
	void Update () {

        print(Vie);
		
	}
		
	//Calcul du score
	public void AugmenteScore(){

		Score++;

		ScoreDisplay.text = Score.ToString ();
	}

	public void ReduireScore()
    {
        Vie--;
        print (Vie);
        life.text = Vie.ToString ();
   	}
		
}
