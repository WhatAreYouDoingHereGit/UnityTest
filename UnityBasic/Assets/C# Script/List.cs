using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> studentList = new List<string>();
        studentList.Add("강대원");
        studentList.Add("민영희");
        studentList.Add("박두팔");
        studentList.Add("안선생");
        studentList.Add("함수빈");
        studentList.Add("구경일"); // 가능

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
