using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawStar : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }
    /*
    star += "★"; // 별
    star += "　"; // 빈칸
    star += "\n"; // 줄바꿈
    */
    public void Phase1()
    {
        star = string.Empty;

        // 페이즈 1
        for(int i = 0; i < 5; i++)
        {
            for( int j = 0; j < i + 1; j++)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈
        }
        star += "\n\n"; // 줄바꿈
        Debug.Log("페이즈 1 : \n" + star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "　"; // 빈칸
            }
            for (int j = 5; j > i; j--)
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈
        }
        Debug.Log("페이즈 2 : \n" + star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3
        for (int i = 0; i < 9; i++)
        {
            if (i < 5)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    star += "★"; // 별
                }
            }
            else
            {
                for (int j = 9; j > i; j--)
                {
                    star += "★"; // 별
                }
            }
            star += "\n"; // 줄바꿈
        }
        Debug.Log("페이즈 3 : \n" + star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4
        for (int i = 0; i < 9; i++)
        {
            if (i < 5)
            {
                for (int j = 5; j > i + 1; j--)
                {
                    star += "　"; // 빈칸
                }
                for (int j = 0; j < i + 1; j++)
                {
                    star += "★"; // 별
                }
            }
            else
            {
                for (int j = 5; j < i + 1; j++)
                {
                    star += "　"; // 빈칸
                }
                for (int j = 9; j > i; j--)
                {
                    star += "★"; // 별
                }
            }
            star += "\n"; // 줄바꿈
        }
        Debug.Log("페이즈 4 : \n" + star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5
        for (int i = 0; i < 9; i++)
        {
            if (i < 5)
            {
                for (int j = 5; j > i + 1; j--)
                {
                    star += "　"; // 빈칸
                }
                for (int j = 0; j < 2*i + 1; j++)
                {
                    star += "★"; // 별
                }
            }
            else
            {
                for (int j = 5; j < i + 1; j++)
                {
                    star += "　"; // 빈칸
                }
                for (int j = 17; j > 2*i; j--) // 별의 개수가 2씩 감소해야 하므로 2*i, i가 5부터 시작, 별 개수는 7부터 시작이므로 5*2 + 7 = 17부터 시작함.
                {
                    star += "★"; // 별
                }
            }
            star += "\n"; // 줄바꿈
        }
        Debug.Log("페이즈 5 : \n" + star);
    }
}
