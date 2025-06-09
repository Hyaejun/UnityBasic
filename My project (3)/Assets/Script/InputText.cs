using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputText : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI textBox1;
    [SerializeField] TMP_InputField inputText;

    public void OnClickButton()
    {
        textBox.text = inputText.text;
        textBox1.text = inputText.text;
    }
}
