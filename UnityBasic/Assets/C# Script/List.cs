using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> studentList = new List<string>();
        studentList.Add("�����");
        studentList.Add("�ο���");
        studentList.Add("�ڵ���");
        studentList.Add("�ȼ���");
        studentList.Add("�Լ���");
        studentList.Add("������"); // ����

        for (int i = 0; i < studentList.Count; i++)
        {
            Debug.Log(studentList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
