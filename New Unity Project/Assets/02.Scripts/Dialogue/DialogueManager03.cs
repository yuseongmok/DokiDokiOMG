using UnityEngine;
using UnityEngine.UI;

public class DialogueManager03 : MonoBehaviour
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
            "X댔다",
            "ㄱ...괜찮으세요??",
            "아니",
            "전혀 괜찮지 않아",
            "당신을 본 순간부터 심장이 마구 뛰기 시작했으니까",
            "ㅇ..어멋..두근..!",
            "그럼 어떻게 배상할거지?",
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