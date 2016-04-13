// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com


// A random walker object

using UnityEngine;
using System.Collections;

public class NOC_I_1_Walker3 : MonoBehaviour {

		public float x, y;
		public int width, height;


		public NOC_I_1_Walker3(){
				x = 0;
				y = 0;
				width = 90;
				height = 90;
		}


		public void Step () {

				float stepx = Random.Range (-1f, 1f);
				float stepy = Random.Range (-1f, 1f);

				x += stepx;
				y += stepy;

				//Contrain xy to stay within limit
				x = Mathf.Clamp(x,-width,width);
				y = Mathf.Clamp(y,-height,height);


		}
}
