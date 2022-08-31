using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//************** agregar para mover botones y texto
using TMPro; // ********* Esto para crear objetos tipo TextMeshPro

public class Scr_TalkPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject dialoguePanel;
    #pragma warning restore 0649

    // We get the text components of dialogue panel
    private TextMeshProUGUI dialogueText, nameText, continueButtonText;
    // We get the button of dialogue panel
    private Button continueButton;

    private List<string> dialogueList;
    private int dialogueID;
    private string name;

    public float visionRadius;
    private Scr_Player player;
    private bool talking;

    // Start is called before the first frame update
    // void Start()
    // {
    //     player = GetComponentInParent<Scr_Player>();
    //     dialogueText = dialoguePanel.GetComponentInChildren<TextMeshProUGUI>();
    //     nameText = dialoguePanel.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>();

    //     //We get the third child of dialogue panel (Buttonn)
    //     continueButton = dialoguePanel.transform.GetChild(2).GetComponent<Button>();
    //     if (continueButton != null)
    //     {
    //         //add listener
    //         continueButtonText = continueButton.GetComponentInChildren<TextMeshProUGUI>();
    //         if (continueButtonText != null)
    //         {
    //             continueButtonText.text = "Continuar";
    //         }
    //     }

    //     dialoguePanel.SetActive(false);
    //     continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
    // }

    // void FixedUpdate()
    // {
    //     float distance = Vector3.Distance(player.transform.position, transform.position);

    //     if (distance < visionRadius){
    //         Debug.Log(distance);                    //hace falta añadir que el cuadro de dialogo aparezca
    //     }
    // }

    // public void SetDialogue(string _name, string[] dialogue)
    // {
    //     Debug.Log("Obteniendo dialogo");
    //     name = _name;
    //     dialogueList = new List<string>(dialogue.Length);
    //     dialogueList.AddRange(dialogue);
    //     dialogueID = 0;
    //     nameText.text = name;
    //     continueButtonText.text = "Continuar";

    //     ShowDialogue();
    //     dialoguePanel.SetActive(true);
    // }

    // public void ShowDialogue()
    // {
    //     dialogueText.text = dialogueList[dialogueID];
    // }

    // public void ContinueDialogue()
    // {
    //     if (dialogueID == dialogueList.Count - 1)//Se termina
    //     {
    //         dialoguePanel.SetActive(false);
    //     }
    //     else if (dialogueID == dialogueList.Count - 2)//Uno antes de terminar
    //     {
    //         continueButtonText.text = "Salir";
    //         dialogueID++;
    //         ShowDialogue();
    //     }
    //     else
    //     {
    //         dialogueID++;
    //         ShowDialogue();
    //     }

    // }

    //  void OnDrawGizmos()
    // {
    //     Gizmos.color = Color.yellow;
    //     Gizmos.DrawWireSphere(transform.position, visionRadius);
    // }
}
