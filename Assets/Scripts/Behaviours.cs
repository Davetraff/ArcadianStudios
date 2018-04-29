using UnityEngine;
using System.Collections;

public class Behaviours : MonoBehaviour {
	
	private Health scriptHealth;
	private CircleCollider2D colliderCircle;
	private float ScaleX = 0.3f;
	private float ScaleY = 0.3f;
	private float ScaleZ = 0.3f;
	
	public float ScaleConstant;
	public float popThreshold;
	
	private AudioSource audioSource;
	public AudioClip[] soundEffectArray;
	private AudioClip soundEffect;

	void Start () {

		audioSource = GetComponent<AudioSource>();
		
		scriptHealth = GetComponent<Health>();
		
		colliderCircle = GetComponent<CircleCollider2D>();
		
		soundEffects (0);
		
	}
	
	// Update is called once per frame
	void Update () {
	
		float currentHealth = scriptHealth.health;

		
		ScaleX = currentHealth * ScaleConstant + popThreshold;
		ScaleY = currentHealth * ScaleConstant + popThreshold;
		ScaleZ = currentHealth * ScaleConstant + popThreshold;
		
		Vector3 newScale = new Vector3 (ScaleX, ScaleY, ScaleZ);
		
		transform.localScale = newScale;
		colliderCircle.transform.localScale = newScale;

	}
	
	void soundEffects (int soundBite){
		soundEffect = soundEffectArray[soundBite];
		audioSource.clip = soundEffect;
		audioSource.Play ();					
}
}