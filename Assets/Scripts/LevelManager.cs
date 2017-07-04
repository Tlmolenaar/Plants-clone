using UnityEngine;
using System.Collections;



public class LevelManager : MonoBehaviour {
	
	public float autoLoadNextLevelAfter = 5f;
	
	void Start(){
		if( autoLoadNextLevelAfter == 0f){
			Debug.Log ("Not autoloading");
		}
		else{
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
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
