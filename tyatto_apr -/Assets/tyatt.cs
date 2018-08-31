using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class tyatt : NetworkBehaviour
{
    // Use this for initialization
    void Start()
    {
        //自分以外であればreturn
        if (!isLocalPlayer)
            return;
        //PostingButtonを押したときにPostingメソッドが呼ばれるようにする
        GameObject.Find("Button").GetComponent<Button>().onClick.AddListener(() => Posting());
    }
    public void Posting()
    {
        InputField inputField = GameObject.Find("InputField").GetComponent<InputField>();
        //クライアント側からサーバにあるPlayerクラスのClone内のメソッドを呼ぶ
        CmdPosting(inputField.text.ToString());
        //inputFieldを白紙にする
        inputField.text = "";
    }
    [Command]
    public void CmdPosting(string ms)
    {
        RpcPosting(ms);
    }
    [ClientRpc]
    public void RpcPosting(string ms)
    {
        Text chatText = GameObject.Find("chatText").GetComponent<Text>();
        chatText.text = ms + "\n" + chatText.text;
    }

}