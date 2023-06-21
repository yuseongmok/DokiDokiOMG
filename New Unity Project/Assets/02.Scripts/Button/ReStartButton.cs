using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReStartButton : MonoBehaviour
{
    public string MainMenu;  // ���� ���� �̸�

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
