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
            Debug.Log("õ������ 'ġŲ Ƽī �����'�� �̾Ҵ�...");
        }
        else
        {
            if (percent == firstTargetPercent)
            {
                Debug.Log("'ġŲ Ƽī �����'�� �̾Ҵ�!!!");
                gatchacount = 0;
            }
            else if (percent > firstTargetPercent & percent <= secondTargetPercent)
            {
                Debug.Log("'����'�� �̾Ҵ�!!");
                gatchacount++;
            }
            else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
            {
                Debug.Log("'�ܹ���'�� �̾Ҵ�!");
                gatchacount++;
            }
            else
            {
                Debug.Log("��ġ�� �̻��ѵ���");
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
                    Debug.Log("'ġŲ Ƽī �����'�� �̾Ҵ�!!!");
                    gatchacount = 0;
                }
                else if (percent > firstTargetPercent & percent <= secondTargetPercent)
                {
                    Debug.Log("'����'�� �̾Ҵ�!!");
                    gatchacount++;
                }
                else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
                {
                    Debug.Log("'�ܹ���'�� �̾Ҵ�!");
                    gatchacount++;
                }
                else
                {
                    Debug.Log("��ġ�� �̻��ѵ���");
                    gatchacount = 0;
                }
                break;
            case 1:
                if (percent == firstTargetPercent)
                {
                    Debug.Log("'������ ���� ����'�� �̾Ҵ�!!!");
                    gatchacount = 0;
                }
                else if (percent > firstTargetPercent & percent <= secondTargetPercent)
                {
                    Debug.Log("'����'�� �̾Ҵ�!!");
                    gatchacount++;
                }
                else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
                {
                    Debug.Log("'�ܹ���'�� �̾Ҵ�!");
                    gatchacount++;
                }
                else
                {
                    Debug.Log("��ġ�� �̻��ѵ���");
                    gatchacount = 0;
                }
                break;
            case 2:
                if (percent == firstTargetPercent)
                {
                    Debug.Log("'�������м�'�� �̾Ҵ�!!!");
                    gatchacount = 0;
                }
                else if (percent > firstTargetPercent & percent <= secondTargetPercent)
                {
                    Debug.Log("'����'�� �̾Ҵ�!!");
                    gatchacount++;
                }
                else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
                {
                    Debug.Log("'�ܹ���'�� �̾Ҵ�!");
                    gatchacount++;
                }
                else
                {
                    Debug.Log("��ġ�� �̻��ѵ���");
                    gatchacount = 0;
                }
                break;
            default:
                Debug.Log("�̻��ѵ���");
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
                Debug.Log("'ġŲ Ƽī �����'�� �̾Ҵ�!!!");
                gatchacount = 0;
            }
            else if (percent > firstTargetPercent & percent <= secondTargetPercent)
            {
                Debug.Log("'����'�� �̾Ҵ�!!");
                gatchacount++;
            }
            else if (percent > secondTargetPercent & percent <= thirdTargetpercent)
            {
                Debug.Log("'�ܹ���'�� �̾Ҵ�!");
                gatchacount++;
            }
            else
            {
                Debug.Log("��ġ�� �̻��ѵ���");
                gatchacount = 0;
            }
        }
    }*/

    [SerializeField] TextMeshProUGUI textmesh;
    string[] character = { "������", "�ѳ���", "����", "��ȣ��", "������", "ä����", "���ƴ�", "������" };
    List<string> characterList = new List<string>();



    void Start()
    {
        characterList.Add("������");
        characterList.Add("�ѳ���");
        characterList.Add("����");
        characterList.Add("��ȣ��");
        characterList.Add("������");
        characterList.Add("ä����");
        characterList.Add("���ƴ�");
        characterList.Add("������");
    }

    public void Arraygatcha()
    {
        int randomValue = Random.Range(0, character.Length);

        textmesh.text = ($"������..\n{character[randomValue]}\n�ٷ� ����̾�!!!");
    }
}
