using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {

	public void levelSwitch (string levelName) {

	SceneManager.LoadScene(levelName);

	}

	public void quitGame () {
		Application.Quit();
	}
}
