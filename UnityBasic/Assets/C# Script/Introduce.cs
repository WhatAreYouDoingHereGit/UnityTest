using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SSH
{
    private string name = "�ռ���";
    private int group = 4;
    private int number = 31;
    private int age = 29;
    private string blood = "A";
    private int height = 186;
    private int weight = 100;
    private string mbti = "INFP";
    private string residence = "õ��";
    private string major = "�����а�";


    public void Start()
    {
        selfIntroduction2(name, group, number, age, blood, height, weight, mbti, residence, major);
    }
    public void selfIntroduction()
    {
        Debug.Log("�� �̸���" + name + "�Դϴ�.");
        Debug.Log($"�� ���̴� {age}�� �Դϴ�.");
        Debug.Log($"���� ���� ���� ��ī���̿��� {number}�� �̸�, �̹� �ǽ����� {group}�� �Դϴ�.");
        Debug.Log("�� ��������" + blood + "�� �Դϴ�.");
        Debug.Log($"�� Ű�� �����Դ� {height}cm, {weight}kg �Դϴ�.");
        Debug.Log("���� MBTI��" + mbti + "�Դϴ�.");
        Debug.Log($"���� ����ִ� ������ {residence}�Դϴ�.");
        Debug.Log($"���� {major} �����Դϴ�.");
    }

    public void selfIntroduction2(string _name, int _group, int _number, int _age, string _blood, int _height, int _weight, string _mbti, string _residence, string _major)
    {
        Debug.Log("�� �̸���" + _name + "�Դϴ�.");
        Debug.Log($"�� ���̴� {_age}�� �Դϴ�.");
        Debug.Log($"���� ���� ���� ��ī���̿��� {_number}�� �̸�, �̹� �ǽ����� {_group}�� �Դϴ�.");
        Debug.Log("�� ��������" + _blood + "�� �Դϴ�.");
        Debug.Log($"�� Ű�� �����Դ� {_height}cm, {_weight}kg �Դϴ�.");
        Debug.Log("���� MBTI��" + _mbti + "�Դϴ�.");
        Debug.Log($"���� ����ִ� ������ {_residence}�Դϴ�.");
        Debug.Log($"���� {_major} �����Դϴ�.");
    }

   

}

public class Introduce : MonoBehaviour
{
    SSH myInfo = new SSH();
    
    // Start is called before the first frame update
    void Start()
    {
        myInfo.selfIntroduction();
        //myInfo.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
