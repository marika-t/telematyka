using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehavior : MonoBehaviour {

	public void triggerMenuBehavior(int i)
	{

		switch (i) {

		default:
			
		case(0):

			SceneManager.LoadScene ("level 1");

			break;
		
		
		case(1):

			Application.Quit();

			break;

		}


	}

}

