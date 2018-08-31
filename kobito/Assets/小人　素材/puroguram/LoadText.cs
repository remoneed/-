using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneEvent
{
    public string[] ev;
}

public class LoadText : MonoBehaviour
{
    [SerializeField]
    private Text textObj;
    [SerializeField]
    private TextAsset jsonData;
    private SceneEvent sceneEvent;//すべての人のセリフJSONから読み込む
    private string[] serif;
    private int textNum1;
    private bool inEvent = false;
    //GameObject game_Object = GameObject.Find("Image");



    public void StartEv(int id)
    {
        GameObject.Find("Canvas").transform.Find("SerifImage").gameObject.SetActive(true);
        inEvent = true;
        textNum1 = 0;
        serif = sceneEvent.ev[id].Split(char.Parse("@"));
        textObj.text = serif[textNum1];
    }


    // Use this for initialization
    void Start()
    {
        GameObject serifImage = GameObject.Find("SerifImage");
        serifImage.gameObject.SetActive(false);

        sceneEvent = JsonUtility.FromJson<SceneEvent>(jsonData.text);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {  //確認用39,40,41は後で消すこと
            StartEv(1);
        }

        /*if(inEvent)
        {
           
        }*/

        if (Input.GetKeyDown(KeyCode.Space) && inEvent)
        {
            textNum1++;
            if (textNum1 < serif.Length)
            {
                if (serif[textNum1] != "")
                {
                    textObj.text = serif[textNum1];

                }

            }
            else
            {
                inEvent = false;
                textObj.text = "";
                GameObject serifImage = GameObject.Find("SerifImage");
                serifImage.gameObject.SetActive(false);

            }
        }
    }
}
