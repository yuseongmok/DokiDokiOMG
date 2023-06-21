using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager06 : MonoBehaviour
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
            "토요일 5시 50분 현우할머니 국밥집",
            "너무 설레서 조금 빨리 와버렸다.",
            "두근..!",
            "저 멀리서 민혁이가 다가오는게 보인다.",
            "그가 다가올수록 심장이 터질거 같이 뛴다.",
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
