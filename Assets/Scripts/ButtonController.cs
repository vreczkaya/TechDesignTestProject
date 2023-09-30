using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Button _button;
    private int _sceneIndexToLoad;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeScene);

        _sceneIndexToLoad = (SceneManager.GetActiveScene().buildIndex == 0) ? 1 : 0;
        Debug.Log(_button.onClick == null);
    }

    public void ChangeScene()
    {

        Debug.Log("change");
        SceneManager.LoadScene(_sceneIndexToLoad);
    } 
}
