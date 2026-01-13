using TMPro;
using UnityEngine;

public class NPC_Dialogue : MonoBehaviour
{
    bool isPlayerNearby = false;
    public GameObject dialogueText;
    TextMeshProUGUI textComponent;
    /*/public string line1;
    public string line2;
    public string line3;
    /*/
    public string[] lines;
    
    int index = 0;


    void Start()
    {
        textComponent = dialogueText.GetComponent<TextMeshProUGUI>();
        dialogueText.SetActive(false);
    }

    void Update()
    {

        if (isPlayerNearby == true && Input.GetKeyDown(KeyCode.E))
        {

            print("Intereacted");
            
            if (!dialogueText.activeSelf)
            {
                dialogueText.SetActive(true);
            }

            if(index < lines.Length)
            {
                textComponent.text = lines[index];
                index++;
                
            }
            else
            {
                dialogueText.SetActive(false);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Appeared");

        if (collision.CompareTag("Player"))
        {
            isPlayerNearby = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("Left");
        if (collision.CompareTag("Player"))
        {
            isPlayerNearby = false;
            ResetDIalogue();
        }
    }

    private void ResetDIalogue()
    {
        index = 0; //går tillbaka till första raden
        dialogueText.SetActive(false); //döljer textrutan
        textComponent.text = ""; //tömer texten
    }
}
