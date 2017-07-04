using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class panelFade : MonoBehaviour {
	public float fadeInTime;
	private Image fadePanel;
	private Color currentColour = Color.black;
	
	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < fadeInTime){
			float alphaColour = Time.deltaTime / fadeInTime;
			currentColour.a -= alphaColour;
			fadePanel.color = currentColour;
		}else{
			gameObject.SetActive (false);
		}
	}
}
