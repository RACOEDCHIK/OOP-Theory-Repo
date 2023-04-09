using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField] private int _sceneIndex = 0;

    public void LoadScene()
    {
        SceneManager.LoadScene(_sceneIndex);
    }
}
