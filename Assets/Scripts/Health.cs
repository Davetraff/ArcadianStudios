using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health;
	public float lifeRate;
	
	private Animator animator;
	
void Start (){
	animator = GetComponent<Animator>();
	
	}	
	// Use this for initialization
	public void DealDamage (float damage){
		health -= damage;
		
	if (health <= 0){
		animator.SetTrigger ("PlopDeath");
	}
}

public void DestroyObject(){
	Destroy (gameObject);
}

void Update (){
	DealDamage (lifeRate);
}
}