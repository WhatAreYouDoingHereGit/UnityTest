using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Star : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI StarTarget;

    int size = 5;
    string starShape = "¡Ú";
    string starblank = "¡¡";

    string strStar = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        //starPhase1();

        //starPhase2();
        
        //starPhase3();
        //starPhase4();
        //starPhase5();
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void starPhase1()
    {
        strStar = string.Empty;

        for (int j = 0; j < size+1; j++)
        {
            for (int i = 0; i < j; i++)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }
        Debug.Log(strStar);
        StarTarget.text = strStar;
    }

    public void starPhase2()
    {
        strStar = string.Empty;

        for (int i = 0; i < size; i++)
        {

            for (int j = 0; j < i; j++)
            {
                strStar += starblank;
            }

            for (int k = size; k > i; k--)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }
        Debug.Log(strStar);
        StarTarget.text = strStar;
    }


    public void starPhase3()
    {
        strStar = string.Empty;

        for (int j = 0; j < size + 1; j++)
        {
            for (int i = 0; i < j; i++)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }

        for (int i = 0; i < size-1; i++)
        {
            for (int j = size-1; j > i; j--)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }
        Debug.Log(strStar);
        StarTarget.text = strStar;

    }

    public void starPhase4()
    {
        strStar = string.Empty;

        for (int i = 0; i < size; i++)
        {

            for (int j = size-1; j > i; j--)
            {
                strStar += starblank;
            }
            for (int k = 0; k < i+1; k++)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }

        for (int i = 0; i < size-1; i++)
        {
            for (int j = 0; j < i+1; j++)
            {
                strStar += starblank;
            }

            for (int k = size-1; k > i; k--)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }
        Debug.Log(strStar);
        StarTarget.text = strStar;

    }


    public void starPhase5()
    {
        strStar = string.Empty;

        for (int i = 0; i < size; i++)
        {
            
            for (int j = size - 1; j > i; j--)
            {
                strStar += starblank;
            }

            for (int k = 0; k < i * 2 + 1; k++)
            {
                strStar += starShape;
            }
            strStar += "\n";
        }

        for (int i = size - 2; i >= 0; i--)
        {
            
            for (int j = 0; j < size - i - 1; j++)
                strStar += starblank;

            for (int k = 0; k < i * 2 + 1; k++)
                strStar += starShape;

            strStar += "\n";
        }

        Debug.Log(strStar);
        StarTarget.text = strStar;

    }
    
}
