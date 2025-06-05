using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Myself : MonoBehaviour
{
    public string myName = "문혜준";
    public string myGender = "남성";
    public int myHeight = 170;

    public int myAge = 25;
    public string myBloodType = "AB+";
    public string myAllergy = "없음";

    public string myMBTI = "INTP";
    public string myJob = "무직";
    public string myResidence = "Icheon";
    public string myFavGame = "CyberPunk 2077";

    public TextMeshProUGUI targetText;  // 연결할 Text


    // Start is called before the first frame update
    void Start()
    {
        Introduction();
        IntroductionBody();
        IntroductionSocial();
    }

    void Introduction()
    {
        Debug.Log($"저의 이름은 {myName}입니다.");
        Debug.Log($"저의 성별은 {myGender}입니다.");
        Debug.Log($"저의 키는 {myHeight}입니다.");
    }

    void IntroductionBody()
    {
        // 다른 방식으로도 출력해보자
        Debug.Log("저의 혈액형은 " + myBloodType + "입니다.");
        Debug.Log("저의 나이는 " + myAge + "입니다.");
        Debug.Log("저의 알레르기는 " + myAllergy + "입니다.");
    }

    void IntroductionSocial()
    {
        Debug.Log($"저의 MBTI는 {myMBTI}입니다.");
        Debug.Log($"저의 직업은 {myJob}입니다.");
        Debug.Log($"저의 거주지는 {myResidence}입니다.");
        Debug.Log($"저의 최애 게임은 {myFavGame}입니다.");
    }

    public void OnClickNameButton()
    {
        targetText.text = myName;
    }

    public void OnClickGenderButton()
    {
        targetText.text = myGender;
    }

    public void OnClickHeightButton()
    {
        targetText.text = myHeight.ToString();
    }

    public void OnClickBloodTypeButton()
    {
        targetText.text = myBloodType;
    }

    public void OnClickAgeButton()
    {
        targetText.text = myAge.ToString();
    }

    public void OnClickAllergyButton()
    {
        targetText.text = myAllergy;
    }

    public void OnClickMBTIButton()
    {
        targetText.text = myMBTI;
    }

    public void OnClickJobButton()
    {
        targetText.text = myJob;
    }

    public void OnClickResidenceButton()
    {
        targetText.text = myResidence;
    }

    public void OnClickFavGameButton()
    {
        targetText.text = myFavGame;
    }
}
