using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

public float autoLoadNextLevel;


	
void Awake(){
		DontDestroyOnLoad(gameObject);
}

void Start(){
	Invoke ("LoadNextLevel", autoLoadNextLevel);

}

public void LoadLevel(string name){
	Application.LoadLevel(name);
}

public void QuitRequest(){
	Application.Quit();
	}

public void LoadNextLevel(){
	Application.LoadLevel (Application.loadedLevel +1);
	}
}