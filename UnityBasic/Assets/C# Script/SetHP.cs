using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SetHP : MonoBehaviour
{
    [SerializeField] Image img_HPBar;
 
    [SerializeField] int MaxHP;
    [SerializeField] float nowHP;

    [SerializeField] TextMeshProUGUI HP_txt;
    [SerializeField] TextMeshProUGUI Dmg_txt;

    int Damage = 1;
    public int HealPoint;

    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        nowHP = MaxHP;
        HP_txt.text = $"{nowHP} / {MaxHP}";
        Dmg_txt.text = "대기 중";
    }

    public void OnClickDamage()
    {
        Damage = Random.Range(1, 12);
        if (Damage > 10)
        {
            Debug.Log("비검천중파!!!!");
        }

        nowHP -= Damage;
        if (nowHP < 0)
        {
            nowHP = 0;
            Debug.Log("죽음을 견뎌냈다!");
        }

        Dmg_txt.text = $"{Damage}의 피해를 받았다!";
        refreshUI();
    }

    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        Dmg_txt.text = $"{HealPoint}의 체력을 회복했다!";
        refreshUI();
    }

    public void refreshUI()
    {
        img_HPBar.fillAmount = nowHP / MaxHP;
        //HP_txt.text = nowHP.ToString();
        HP_txt.text = $"{nowHP} / {MaxHP}";
    }
}
