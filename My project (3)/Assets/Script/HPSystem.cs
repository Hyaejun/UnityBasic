using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class HPSystem : MonoBehaviour
{
    public Image ImgHPbar;
    public TextMeshProUGUI TextHP;
    public TextMeshProUGUI TextPrint;
    public int MaxHP = 100;
    float nowHP;

    public int Damage = 5;
    public int HealPoint = 5;

    void Awake()
    {
        nowHP = MaxHP;
        TextHP.text = "100 / 100";
    }

    public void OnClickDamage()
    {
        Damage = Random.Range(1, 20);

        nowHP -= Damage;
        if (nowHP <= 0)
        {
            nowHP = 0;
        }
        RefreshUI();
        TextPrint.text = $"{Damage} 데미지를 입었습니다.";

    }

    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if (nowHP >= MaxHP)
        {
            nowHP = MaxHP;
        }
        RefreshUI();
    }

    void RefreshUI()
    {
        ImgHPbar.fillAmount = nowHP / MaxHP;
        TextHP.text = nowHP + " / " + MaxHP;
    }

}
