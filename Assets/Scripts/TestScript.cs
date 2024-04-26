using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite Kid;
    public Sprite Sejong;
    public Sprite Background;
}


// Start is called before the first frame update
public class TestScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_Kid;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private SpriteRenderer sprite_Sejong;
    [SerializeField] private SpriteRenderer sprite_Background;


    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;
    // Start is called before the first frame update
    public void ShowDialogue()
    {
        OnOff(true);

        count = 0;
        isDialogue = true;
        NextDialogue();
    }
    private void OnOff(bool flag)
    {
        sprite_Sejong.gameObject.SetActive(flag);  
        sprite_DialogueBox.gameObject.SetActive(flag);
        sprite_Kid.gameObject.SetActive(flag);
        txt_Dialogue.gameObject.SetActive(flag);

        isDialogue = flag;
    }


    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_Kid.sprite = dialogue[count].Kid;
        sprite_Sejong.sprite = dialogue[count].Sejong;
        sprite_Background.sprite = dialogue[count].Background;


        count++;
    }

    
    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                    OnOff(false);
            }
        }
    }
}
