using UnityEngine;
using System.Collections;



public class LevelManager : MonoBehaviour {
	
	public float autoLoadNextLevelAfter = 5;
	
	void Start(){
		Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
	}
	
	public void LoadLevel(string name){
		Debug.Log ("Level load requested for: "+name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log ("Quit game");
		Application.Quit ();
	}
	
	public void LoadNextLevel (){
		Application.LoadLevel(Application.loadedLevel +1);
	}
	
	
}
