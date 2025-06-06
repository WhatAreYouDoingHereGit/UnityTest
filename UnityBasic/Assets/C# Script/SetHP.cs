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
        Dmg_txt.text = "��� ��";
    }

    public void OnClickDamage()
    {
        Damage = Random.Range(1, 12);
        if (Damage > 10)
        {
            Debug.Log("���õ����!!!!");
        }

        nowHP -= Damage;
        if (nowHP < 0)
        {
            nowHP = 0;
            Debug.Log("������ �ߵ��´�!");
        }

        Dmg_txt.text = $"{Damage}�� ���ظ� �޾Ҵ�!";
        refreshUI();
    }

    public void OnClickHeal()
    {
        nowHP += HealPoint;
        if (nowHP > MaxHP)
        {
            nowHP = MaxHP;
        }

        Dmg_txt.text = $"{HealPoint}�� ü���� ȸ���ߴ�!";
        refreshUI();
    }

    public void refreshUI()
    {
        img_HPBar.fillAmount = nowHP / MaxHP;
        //HP_txt.text = nowHP.ToString();
        HP_txt.text = $"{nowHP} / {MaxHP}";
    }
}
