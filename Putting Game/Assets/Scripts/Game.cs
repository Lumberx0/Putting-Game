using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Game : EventTrigger {

Vector3 mMouseDownPos;
Vector3 mMouseUpPos;
public float speed = 1f;
public Rigidbody2D rb;
public Text text;

	void OnMouseDown() {

		mMouseDownPos = Input.mousePosition;
     	Debug.Log( "the mouse down pos is " + mMouseDownPos.z.ToString() );
     	mMouseDownPos.z = 0;

	}
	void OnMouseUp ()
	{
		mMouseUpPos = Input.mousePosition;
     	mMouseUpPos.z = 0;
     	var direction = mMouseDownPos - mMouseUpPos;
     	direction.Normalize();
     	rb.AddForce (direction * speed);
     	Debug.Log( "the mouse up pos is " + mMouseUpPos.ToString() );
	}
	void Start() {
		rb = GetComponent<Rigidbody2D>();
	}



}
