using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SSH
{
    private string name = "손석현";
    private int group = 4;
    private int number = 31;
    private int age = 29;
    private string blood = "A";
    private int height = 186;
    private int weight = 100;
    private string mbti = "INFP";
    private string residence = "천안";
    private string major = "게임학과";


    public void Start()
    {
        selfIntroduction2(name, group, number, age, blood, height, weight, mbti, residence, major);
    }
    public void selfIntroduction()
    {
        Debug.Log("제 이름은" + name + "입니다.");
        Debug.Log($"제 나이는 {age}살 입니다.");
        Debug.Log($"저는 경일 게임 아카데미에서 {number}번 이며, 이번 실습에서 {group}조 입니다.");
        Debug.Log("제 혈앵형은" + blood + "형 입니다.");
        Debug.Log($"제 키와 몸무게는 {height}cm, {weight}kg 입니다.");
        Debug.Log("저의 MBTI는" + mbti + "입니다.");
        Debug.Log($"제가 살고있는 지역은 {residence}입니다.");
        Debug.Log($"저는 {major} 전공입니다.");
    }

    public void selfIntroduction2(string _name, int _group, int _number, int _age, string _blood, int _height, int _weight, string _mbti, string _residence, string _major)
    {
        Debug.Log("제 이름은" + _name + "입니다.");
        Debug.Log($"제 나이는 {_age}살 입니다.");
        Debug.Log($"저는 경일 게임 아카데미에서 {_number}번 이며, 이번 실습에서 {_group}조 입니다.");
        Debug.Log("제 혈앵형은" + _blood + "형 입니다.");
        Debug.Log($"제 키와 몸무게는 {_height}cm, {_weight}kg 입니다.");
        Debug.Log("저의 MBTI는" + _mbti + "입니다.");
        Debug.Log($"제가 살고있는 지역은 {_residence}입니다.");
        Debug.Log($"저는 {_major} 전공입니다.");
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
