using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButton2 : MonoBehaviour
{
    public string GameOverScene2;  // ���� ���� �̸�

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(GameOverScene2);
    }
}
