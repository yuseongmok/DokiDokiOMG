using UnityEngine;
using UnityEngine.UI;

public class DialogueManager05 : MonoBehaviour
{
    public Text dialogueText;
    public Button nextButton;

    private string[] dialogues;  // 대화 내용을 저장할 배열
    private int currentIndex;   // 현재 대화 인덱스

    private void Start()
    {
        // 대화 내용 초기화
        dialogues = new string[]
        {
            "그렇게 그는 번호를 남기고 떠나버렸다",
            "꿈인가?",
            "내가 그 최고 인기 광대 오민혁과 데이트를 하다니..",
            "갑작스래 벌어진 일에 정신을 차릴수가 없었다",
            // 원하는 만큼 대사를 추가할 수 있습니다.
        };

        // 버튼 클릭 이벤트에 함수 연결
        nextButton.onClick.AddListener(ShowNextDialogue);

        // 초기 대사 표시
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        dialogueText.text = dialogues[currentIndex];
    }

    private void ShowNextDialogue()
    {
        // 다음 대사로 이동
        currentIndex++;

        // 대화가 끝났으면 버튼 비활성화
        if (currentIndex >= dialogues.Length)
        {
            nextButton.interactable = false;
            return;
        }

        // 다음 대사 표시
        ShowDialogue();
    }
}
