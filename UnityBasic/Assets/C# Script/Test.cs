using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    /*
    private void Awake()
    {
        Debug.Log("���� �� ���� ����˴ϴ�.");
    }

    private void OnEnable()
    {
        Debug.Log("Ȱ��ȭ �� �� ����˴ϴ�. ");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�ѹ��� ����˴ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("������ ����˴ϴ�.");
    }*/

    void Start()
    {
        Random.InitState(1);
    }

    void Update()
    {
        Debug.Log(Random.Range(1, 100));    
    }
}
