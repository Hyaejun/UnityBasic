using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Study : MonoBehaviour
{
    // Start is called before the first frame update
    /*void OnEnable()
    {
        Random.InitState(1);
        Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
    }
    */

    int playerLevel = 10;

    string playerName;

    void Start()
    {
        playerName += "나의 이름은 ";
        playerName += "문혜준 ";
        playerName += "입니다";

        Debug.Log("나의 레벨은 " + playerLevel + "입니다.");
        Debug.Log($"나의 레벨은 {playerLevel}입니다.");
        Debug.Log(playerName);
    }
}