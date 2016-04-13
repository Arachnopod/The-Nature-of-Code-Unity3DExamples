// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com


// A random walker object

using UnityEngine;
using System.Collections;

public class NOC_I_1_Walker : MonoBehaviour {

		public int x, y;
		public int width, height;


		public NOC_I_1_Walker(){
				//in Unity 0 = center of the screen
				x = 0;
				y = 0;
				width = 90;
				height = 90;

		}


		public void Step () {
				int choice = Random.Range (0, 4);

				if (choice == 0) {
						x++;
				} else if (choice == 1) {
						x--;
				} else if (choice == 2) {
						y++;
				} else {
						y--;
				}


				x = Mathf.Clamp(x,-width,width);
				y = Mathf.Clamp(y,-height,height);


		}

		public void Render(){

		}
}
