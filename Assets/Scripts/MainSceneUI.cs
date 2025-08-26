using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainSceneUI : MonoBehaviour
{
    public TMP_Text nameText;
    void Start()
    {
        nameText.text = "Name: " + PlayerData.Instance.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
