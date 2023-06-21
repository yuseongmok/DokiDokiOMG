using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Button nextButton;

    private string[] dialogues;  // ��ȭ ������ ������ �迭
    private int currentIndex;   // ���� ��ȭ �ε���

    private void Start()
    {
        // ��ȭ ���� �ʱ�ȭ
        dialogues = new string[]
        {
            "���� 25�� ����� ������",
            "����ϰ� ī���� ������ ���� ī�信 �鷶��.",
            "��Һ��� ī�䰡 �Ҷ������� �������̶� �°ɱ�?",
            "�ƴ�..! �� �����...!?",
            // ���ϴ� ��ŭ ��縦 �߰��� �� �ֽ��ϴ�.
        };

        // ��ư Ŭ�� �̺�Ʈ�� �Լ� ����
        nextButton.onClick.AddListener(ShowNextDialogue);

        // �ʱ� ��� ǥ��
        ShowDialogue();
    }

    private void ShowDialogue()
    {
        dialogueText.text = dialogues[currentIndex];
    }

    private void ShowNextDialogue()
    {
        // ���� ���� �̵�
        currentIndex++;

        // ��ȭ�� �������� ��ư ��Ȱ��ȭ
        if (currentIndex >= dialogues.Length)
        {
            nextButton.interactable = false;
            return;
        }

        // ���� ��� ǥ��
        ShowDialogue();
    }
}
