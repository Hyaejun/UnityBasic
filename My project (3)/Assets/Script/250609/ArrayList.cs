using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrayList : MonoBehaviour
{
    int[] array = new int[3];
    List<int> list = new List<int>();

    int[] array2 = {100, 200, 300, 400 }; // 이런 형식도 가능.
    
    // Start is called before the first frame update
    void Start()
    {
        array[0] = 100;
        array[1] = 200;
        array[2] = 300;

        list.Add(100);
        list.Add(200);
        list.Add(300);
        list.Add(400);
        list.Add(500);
        list.Add(600);
        list.Add(700);

        list[5] = 1000;

        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);

        for(int i = 0; i < 7; i++ )
        {
            Debug.Log(list[i]);
        }
    }

    public TextMeshProUGUI Txt_Bumin;

    string[] character = { "정은교", "김한나", "손석현", "이윤호", "엄지성", "박현아", "차정훈", "최현석" };
    List<string> characterList = new List<string>();

    public void ArrayGacha() // character.Length
    {
        int randomValue = Random.Range(0, character.Length); // 8 , 0 ~ 7

        Debug.Log("범인은? " + character[randomValue] + "님 였습니다.");
        Txt_Bumin.text = "범인은? " + character[randomValue] + "님 였습니다.";
    }

    public void ListGacha() // characterList.Count
    {
        int randomValue = Random.Range(0, characterList.Count);  // 8 , 0 ~ 7
        Txt_Bumin.text = "범인은? " + characterList[randomValue] + "님 였습니다.";
    }

    public void AddList()
    {
        // character 배열에는 사람 이름이 있습니다.
        // characterList에는 아무 데이터도 없습니다.

        // character 배열의 데이터를 charcterList에다가 넣어주는 식을 만들어봅시다.
        // 우리가 배운 반복문을 사용해서 만들어 봅시다.

        for (int i = 0; i < character.Length; i++) // i < 8 -> 0 ~ 7
        {
            characterList.Add(character[i]);
        }

        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }
}
