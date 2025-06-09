using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count;
    private void Awake()
    {
        count = 0;
    }

    void Start()
    {
        // 10%의 확률로 각청
        // 20%의 확률로 모나
        // 70%의 확률로 치치
        /*
        int pos = Random.Range(0, 10); // 0 이상 10 미만의 값
        if (pos < 1)
        {
            Debug.Log("각청을 뽑았다!!!!!");
        }
        else if (pos < 3)
        {
            Debug.Log("모나를 뽑았다.");
        }
        else
        {
            Debug.Log("치치를 뽑았다...");
        }
        */
        /*
        // 등급 결정
        int pos = Random.Range(0, 10); // 0 이상 10 미만의 값
        for(int i = 0; i < 10; i++)
        {
            if (pos < 1)
            {
                Debug.Log("S 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            else if (pos < 3)
            {
                Debug.Log("A 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            else
            {
                Debug.Log("B 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
        }
        for(int i = 0; i < 10; i++)
        {
            Debug.Log("반복문이 " + (i + 1) + "번 실행되었어요!");
        }
        */
    }
    public void GachaIf()
    {
        int pos = Random.Range(0, 10); // 0 이상 10 미만의 값
        if (count >= 7) // 8번째 가챠 시점에서 확정 뽑기(0 1 2 3 4 5 6 7 <-여기!)
        {
            Debug.Log("확정으로 S 등급 캐릭터를 뽑았다!");
            count = 0;
        }
        else if (pos < 1)
        {
            Debug.Log("S 등급!");
            pos = Random.Range(1, 6);
            Debug.Log(pos + "번 캐릭터");
        }
        else if (pos < 3)
        {
            Debug.Log("A 등급!");
            pos = Random.Range(1, 6);
            Debug.Log(pos + "번 캐릭터");
        }
        else
        {
            Debug.Log("B 등급!");
            pos = Random.Range(1, 6);
            Debug.Log(pos + "번 캐릭터");
        }
        count++;
    }

    public void GachaSwitch()
    {
        int pos = Random.Range(0, 10); // 0 이상 10 미만의 값
        if (count >= 7) // 8번째 가챠 시점에서 확정 뽑기(0 1 2 3 4 5 6 7 <-여기!)
        {
            Debug.Log("확정으로 S 등급 캐릭터를 뽑았다!");
            count = 0;
        }
        else
        {
            switch (pos)
            {
                case 0:
                    Debug.Log("S 등급!");
                    pos = Random.Range(1, 6);
                    Debug.Log(pos + "번 캐릭터");
                    count++;
                    break;
                case 1:
                    Debug.Log("A 등급!");
                    pos = Random.Range(1, 6);
                    Debug.Log(pos + "번 캐릭터");
                    count++;
                    break;
                case 2:
                    Debug.Log("A 등급!");
                    pos = Random.Range(1, 6);
                    Debug.Log(pos + "번 캐릭터");
                    count++;
                    break;
                default:
                    Debug.Log("B 등급!");
                    pos = Random.Range(1, 6);
                    Debug.Log(pos + "번 캐릭터");
                    count++;
                    break;
            }
        }
    }


    public void GachaIf10()
    {
        int pos = Random.Range(0, 10); // 0 이상 10 미만의 값
        for(int i = 0; i < 10; i++)
        {
            if (pos < 1)
            {
                Debug.Log("S 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            else if (pos < 3)
            {
                Debug.Log("A 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            else
            {
                Debug.Log("B 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            Debug.Log("현재까지 " + (i + 1) + "연차!");
        }
    }

    public void GachaWhile10()
    {
        int repeat = 0;
        int pos;
        while(repeat < 10)
        {
            pos = Random.Range(0, 10); // 0 이상 10 미만의 값
            if (pos < 1)
            {
                Debug.Log("S 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            else if (pos < 3)
            {
                Debug.Log("A 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            else
            {
                Debug.Log("B 등급!");
                pos = Random.Range(1, 6);
                Debug.Log(pos + "번 캐릭터");
            }
            Debug.Log("현재까지 " + (repeat + 1) + "연차!");
            repeat++;
        }
    }
}
