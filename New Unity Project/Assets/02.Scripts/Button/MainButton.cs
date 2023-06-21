using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainButton : MonoBehaviour
{
    public string PlayScenes01;  // ���� ���� �̸�

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(PlayScenes01);
    }
}
