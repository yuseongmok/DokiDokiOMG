using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReStartButton : MonoBehaviour
{
    public string MainMenu;  // 다음 씬의 이름

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
