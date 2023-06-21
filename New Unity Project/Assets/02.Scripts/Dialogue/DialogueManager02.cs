using UnityEngine;
using UnityEngine.UI;

public class DialogueManager02 : MonoBehaviour
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
            "인기 광대 카사노바 오민혁..!",
            "실물을 볼 줄이야..",
            "두근",
            "어..엇!",
            "그의 빛이 나는 외모에 정신이 팔린 나는 그만",
            "중심을 잃고 쓰러져 그의 옷에 커피를 쏟아버렸다.",
            "으악! 나의 아끼는 파란정장이!!",
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
