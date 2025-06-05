using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Context : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;
    public string NextText;

    public void OnClickButton()
    {
        Txt_Text.text = NextText;
    }
}

