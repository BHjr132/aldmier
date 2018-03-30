using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_enterMultiplayer : MonoBehaviour {

    public void playMultiplayer (string sceneToChangeTo) {
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
