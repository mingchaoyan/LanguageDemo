using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public void OnClickButton() {
		string sceneName = SceneManager.GetActiveScene().name;
		Debug.Log(sceneName);

		if(sceneName == "Main") {
			SceneManager.LoadScene(1);
		} else {
			SceneManager.LoadScene(0);
		}
	}

}
