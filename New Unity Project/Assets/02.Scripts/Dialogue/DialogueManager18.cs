using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager18 : MonoBehaviour
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
            "민혁씨..!",
            "흠?",
            "나랑 사귀어 주세요..!!",
            "훗..이게 287번째 받는 고백인가",
            "...!",
            "미안하지만 넌 하룻밤의 불장난이였어",
            "누구도 날 품을 수 없다.",
            "그럼 아디오스",
            "당신은 화를 참을 수 없어 주먹을 불끈 쥐고 민혁이를 쫒아갑니다"

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
