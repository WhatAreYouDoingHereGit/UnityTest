using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Txt_Text;
    [SerializeField] private TextMeshProUGUI TargetText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButton()
    {
        Txt_Text.text = TargetText.text;
    }
}
