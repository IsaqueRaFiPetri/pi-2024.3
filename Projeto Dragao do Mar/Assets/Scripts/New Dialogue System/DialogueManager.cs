using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // Texto para exibir o di�logo
    //public TextMeshProUGUI nameText; // Texto para exibir o di�logo
    public GameObject dialoguePanel; // Painel de di�logo
    public Button[] responseButtons; // Array de bot�es de resposta

    private Queue<string> sentences; // Fila de frases do di�logo atual
    private Dialogue currentDialogue; // Refer�ncia ao di�logo atual

    void Start()
    {
        sentences = new Queue<string>();
        dialoguePanel.SetActive(false);
        HideResponseButtons();
    }

    // M�todo para iniciar o di�logo
    public void StartDialogue(Dialogue dialogue)
    {
        currentDialogue = dialogue;
        dialoguePanel.SetActive(true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    // Exibir a pr�xima frase do di�logo
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            DisplayResponses();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    // Coroutine para animar o texto sendo exibido
    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    // Exibe as op��es de resposta
    void DisplayResponses()
    {
        if (currentDialogue.options.Length > 0)
        {
            for (int i = 0; i < currentDialogue.options.Length; i++)
            {
                responseButtons[i].gameObject.SetActive(true);
                responseButtons[i].GetComponentInChildren<TMP_Text>().text = currentDialogue.options[i].responseText;

                // Adiciona o listener ao bot�o
                int optionIndex = i; // Cria��o de uma c�pia local para evitar problemas de escopo
                responseButtons[i].onClick.RemoveAllListeners();
                responseButtons[i].onClick.AddListener(() => OnResponseSelected(optionIndex));
            }
        }
        else
        {
            EndDialogue();
        }
    }

    // M�todo chamado quando uma resposta � selecionada
    void OnResponseSelected(int optionIndex)
    {
        HideResponseButtons();
        DialogueOption selectedOption = currentDialogue.options[optionIndex];
        if (selectedOption.nextDialogue != null)
        {
            StartDialogue(selectedOption.nextDialogue);
        }
        else
        {
            EndDialogue();
        }
    }

    // Oculta os bot�es de resposta
    void HideResponseButtons()
    {
        foreach (Button button in responseButtons)
        {
            button.gameObject.SetActive(false);
        }
    }

    // M�todo para encerrar o di�logo
    void EndDialogue()
    {
        PlayerStats.instance.SetWalkingMode();
        dialoguePanel.SetActive(false);
        HideResponseButtons();
        Debug.Log("Fim do di�logo.");
    }
}
