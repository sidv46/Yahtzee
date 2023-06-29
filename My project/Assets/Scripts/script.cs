using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.LogWarning("No next scene found. Make sure scenes are added in Build Settings.");
        }
    }
}
