// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com


// A random walker object

using UnityEngine;
using System.Collections;

public class NOC_I_1_Walker2 : MonoBehaviour {

		public int x, y;
		public int width, height;


		public NOC_I_1_Walker2(){
				x = 0;
				y = 0;
				width = 90;
				height = 90;
		}


		public void Step () {

				int stepx = Random.Range (0, 3) - 1;
				int stepy = Random.Range (0, 3) - 1;

				x += stepx;
				y += stepy;

				//Contrain xy to stay within limit
				x = Mathf.Clamp(x,-width,width);
				y = Mathf.Clamp(y,-height,height);


		}
}
