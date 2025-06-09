using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{/*
    int gatchacount = 0;

    public int pickupbanner = 0;

    int firstTargetPercent = 10;
    int secondTargetPercent = 30;
    int thirdTargetpercent = 100;
    // Start is called before the first frame update
    void Start()
    {
        gatchacount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gatcha()
    {
        int percent = 0;
        percent = Random.Range(0, 100);

        Debug.Log(percent);
        Debug.Log(gatchacount);

        if (gatchacount == 8)
        {
            Debug.Log("천장으로 '치킨 티카 마살라'를 뽑았다...");
        }
        else
        {
            if (percent == firstTargetPercent)
            {
                Debug.Log("'치킨 티카 마살라'를 뽑았다!!!");
                gatchacount = 0;
            }
            else if (percent > firstTargetPercent & percent <= secondTargetPercent)
            {
                Debug.Log("'피자'를 뽑았다!!");
                gatchacount++;
            }
            else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
            {
                Debug.Log("'햄버거'를 뽑았다!");
                gatchacount++;
            }
            else
            {
                Debug.Log("수치가 이상한데오");
                gatchacount = 0;
            }
        }
        
    }

    public void pickupgatcha()
    {
        int percent = 0;
        percent = Random.Range(0, 100);
        Debug.Log(percent);
        Debug.Log(gatchacount);

        switch (pickupbanner)
        {
            case 0:
                if (percent == firstTargetPercent)
                {
                    Debug.Log("'치킨 티카 마살라'를 뽑았다!!!");
                    gatchacount = 0;
                }
                else if (percent > firstTargetPercent & percent <= secondTargetPercent)
                {
                    Debug.Log("'피자'를 뽑았다!!");
                    gatchacount++;
                }
                else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
                {
                    Debug.Log("'햄버거'를 뽑았다!");
                    gatchacount++;
                }
                else
                {
                    Debug.Log("수치가 이상한데오");
                    gatchacount = 0;
                }
                break;
            case 1:
                if (percent == firstTargetPercent)
                {
                    Debug.Log("'항정살 간장 조림'을 뽑았다!!!");
                    gatchacount = 0;
                }
                else if (percent > firstTargetPercent & percent <= secondTargetPercent)
                {
                    Debug.Log("'피자'를 뽑았다!!");
                    gatchacount++;
                }
                else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
                {
                    Debug.Log("'햄버거'를 뽑았다!");
                    gatchacount++;
                }
                else
                {
                    Debug.Log("수치가 이상한데오");
                    gatchacount = 0;
                }
                break;
            case 2:
                if (percent == firstTargetPercent)
                {
                    Debug.Log("'슈바인학센'을 뽑았다!!!");
                    gatchacount = 0;
                }
                else if (percent > firstTargetPercent & percent <= secondTargetPercent)
                {
                    Debug.Log("'피자'를 뽑았다!!");
                    gatchacount++;
                }
                else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
                {
                    Debug.Log("'햄버거'를 뽑았다!");
                    gatchacount++;
                }
                else
                {
                    Debug.Log("수치가 이상한데오");
                    gatchacount = 0;
                }
                break;
            default:
                Debug.Log("이상한데용");
                break;
        }
    }

    public void pickup10gatch()
    {
        for(int i = 0; i < 10; i++)
        {
            int percent = 0;
            percent = Random.Range(0, 100);

            if (percent == firstTargetPercent)
            {
                Debug.Log("'치킨 티카 마살라'를 뽑았다!!!");
                gatchacount = 0;
            }
            else if (percent > firstTargetPercent & percent <= secondTargetPercent)
            {
                Debug.Log("'피자'를 뽑았다!!");
                gatchacount++;
            }
            else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
            {
                Debug.Log("'햄버거'를 뽑았다!");
                gatchacount++;
            }
            else
            {
                Debug.Log("수치가 이상한데오");
                gatchacount = 0;
            }
        }
    }*/

    [SerializeField] TextMeshProUGUI textmesh;
    string[] character = { "은교님", "한나님", "석현", "윤호님", "지성님", "채현님", "정훈님", "현석님" };
    List<string> characterList = new List<string>();



    void Start()
    {
        characterList.Add("은교님");
        characterList.Add("한나님");
        characterList.Add("석현");
        characterList.Add("윤호님");
        characterList.Add("지성님");
        characterList.Add("채현님");
        characterList.Add("정훈님");
        characterList.Add("현석님");
    }

    public void Arraygatcha()
    {
        int randomValue = Random.Range(0, character.Length);

        textmesh.text = ($"범인은..\n{character[randomValue]}\n바로 당신이야!!!");
    }
}
