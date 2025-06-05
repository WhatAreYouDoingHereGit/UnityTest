using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    /*
    private void Awake()
    {
        Debug.Log("최초 한 번만 실행됩니다.");
    }

    private void OnEnable()
    {
        Debug.Log("활성화 될 때 실행됩니다. ");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("한번만 실행됩니다.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("여러번 실행됩니다.");
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
