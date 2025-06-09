using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gacha10 : MonoBehaviour
{
    // 캐릭터들의 이름을 저장하는 리스트 생성
    List<string> characterList = new List<string>();

    // 가챠 결과를 저장하는 리스트 생성
    List<string> GachaList = new List<string>();

    // 새로운 캐릭터를 추가하기 위한 인풋 필드
    [SerializeField] TMP_InputField getCharacterName;

    // UI 상에 결과를 출력하기 위한 텍스트
    public TextMeshProUGUI showGachaName;

    // 가챠 천장을 위한 변수
    private int limit;

    // 천장 정도를 보여주기 위한 텍스트
    public TextMeshProUGUI showLimit;

    private void Awake()
    {
        // 기본적으로 치치만 존재, 추가로 더 넣을 수도 있음
        characterList.Add("치치4성");
        characterList.Add("치치3성");
        characterList.Add("치치3성");
        characterList.Add("치치2성");
        characterList.Add("치치2성");
        characterList.Add("치치1성");
        characterList.Add("치치1성");
        characterList.Add("치치1성");
        // 천장 : 0에서부터 시작
        showLimit.text = "천장  스택 : 0";
    }

    // 10연 가챠 함수
    public void GachaCharacter()
    {
        // 출력을 위한 텍스트는 새로운 가챠 결과 출력을 위해 비운다.
        showGachaName.text = null;
        for (int i = 0; i < 10; i++)
        {
            // 천장을 쳤으면?
            if (limit >= 80)
            {
                Debug.Log("당신이 확정으로 뽑은 캐릭터는 " + characterList[0] + "입니다.");
                // 확정 획득!
                showGachaName.text += characterList[0] + "\n";
                limit = 0;
            }
            else
            {
                // random을 100으로 사용해 백분율로 쓰지 않은 이유는,
                // list의 특성(요소 더하기, 빼기)를 활용해 확률을 조절할 수 있기 때문에 이렇게 만들어 보았습니다.
                // 리스트 범위 내에서 랜덤하게 숫자 뽑고,
                int random = Random.Range(0, characterList.Count);
                // 그 숫자에 할당한 캐릭터가 뽑혔다고 친다.
                Debug.Log("당신이 뽑은 캐릭터는 " + characterList[random] + "입니다.");
                // 그리고 화면의 텍스트에 표시한다.
                showGachaName.text += characterList[random] + "\n";
                // 한정캐를 이미 뽑았으면?
                if (random == 0)
                {
                    // 천장 스택 초기화
                    limit = 0;
                }
                limit++;
                showLimit.text = "천장  스택 : " + limit;
            }
        }
    }

    // 새 캐릭터 추가 함수
    public void AddCharacter()
    {
        // 리스트에 추가한다.
        characterList.Add(getCharacterName.text);
        // 추가가 완료되었으면 입력창을 비운다.
        getCharacterName.text = null;
        // 잘 들어왔는지 확인
        for (int i = 0; i < characterList.Count; i++)
        {
            Debug.Log(characterList[i]);
        }
    }
}
