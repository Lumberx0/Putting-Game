using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GoalScript : MonoBehaviour {

public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Goal") {
			text.text = "Level Completed!";
			Die();
		}

	}
	void Die()
    {
        Destroy(gameObject);
    }

}
