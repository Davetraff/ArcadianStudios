using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

public float fadeTime;

private Image fadePanel;
private Color currentColour = Color.black;

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < fadeTime){
		float alphaChange = Time.deltaTime/fadeTime;
		currentColour.a -= alphaChange;
		fadePanel.color = currentColour;
	}else{
	gameObject.SetActive (false);
}
}
}