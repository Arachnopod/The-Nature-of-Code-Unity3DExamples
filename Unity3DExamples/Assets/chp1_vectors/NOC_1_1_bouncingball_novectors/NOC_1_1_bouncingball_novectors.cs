// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Convertion to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

using UnityEngine;
using System.Collections;

public class NOC_1_1_bouncingball_novectors : MonoBehaviour {
	
	
	public Transform target;		//GameObject to bounce around
	public float x = 0.0f;
	public float y = 0.0f;
	public float xspeed = 0.0f;
	public float yspeed = 0.0f;
	
	void setup()
	{
	}

	
	// Update is called once per frame
	void Update () {
	
		//convert 3D space to screen space
		Vector3 viewPos = camera.WorldToViewportPoint(target.position);
		Vector3 worldPos = camera.ViewportToWorldPoint(viewPos);
		
		//x = x + xspeed;
		//y = y + yspeed;
		
		print ("Balls is at " + x +"  "+ y + " while viewPos.x = " + viewPos.x);
		print (worldPos.x);
		
		//worldPos.x = x;
		//worldPos.y = y;
		
		//target.Translate(x,y,0);
		target.position = worldPos;
		

		if (viewPos.x > 1){
			//worldPos = camera.ViewportToWorldPoint(1.0,worldPos.y,0.0);
			xspeed = xspeed * -1.0f;
		}
//		if (viewPos.y > 1.0f){
//			yspeed = yspeed * -1.0f;
//			y = 0.0f;
//		}				

	}
}

