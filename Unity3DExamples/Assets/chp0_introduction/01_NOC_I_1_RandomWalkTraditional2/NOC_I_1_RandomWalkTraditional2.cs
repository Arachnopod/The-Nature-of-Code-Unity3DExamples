// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C#/Unity by Joseph Fiola
// http://www.joefiola.com


using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class NOC_I_1_RandomWalkTraditional2 : MonoBehaviour {

		private NOC_I_1_Walker2 w;

		//some Unity specific code to draw lines
		LineRenderer lineRenderer;
		private	List<Vector2> pos = new List<Vector2>();	//store position values in a list to be used with lineRenderer
			

		void Start () {
				w = new NOC_I_1_Walker2();

				//some Unity specific code to draw lines
				lineRenderer = this.gameObject.AddComponent<LineRenderer>();
				lineRenderer.material = new Material(Shader.Find("Particles/Multiply"));
				lineRenderer.SetColors(Color.black, Color.black);
				lineRenderer.SetWidth(1.0F, 1.0F);
				lineRenderer.SetVertexCount(pos.Count);
		}
	
		// Update is called once per frame
		void Update () {

				w.Step();

				//add current Walker xy position to our list
				pos.Add(new Vector2(w.x,w.y));

				lineRenderer.SetVertexCount(pos.Count);
				for (int i = 0; i < pos.Count; i++) {
						lineRenderer.SetPosition (i, new Vector3(pos[i].x,pos[i].y,0));
				}
		}
}
