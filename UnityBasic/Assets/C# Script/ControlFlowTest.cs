using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlFlowTest : MonoBehaviour
{
    List<string> characterPull = new List<string>();


    [SerializeField] Image firstSocket;
    [SerializeField] Image secondSocket;
    [SerializeField] Image thirdSocket;
    [SerializeField] Image fourthSocket;
    [SerializeField] Image fifthSocket;
    [SerializeField] Image sixthSocket;
    [SerializeField] Image seventhSocket;
    [SerializeField] Image eighthSocket;
    [SerializeField] Image ninthSocket;
    [SerializeField] Image tenthSocket;

    [SerializeField] TextMeshProUGUI firstNametxt;
    [SerializeField] TextMeshProUGUI secondNametxt;
    [SerializeField] TextMeshProUGUI thirdNametxt;
    [SerializeField] TextMeshProUGUI fourthNametxt;
    [SerializeField] TextMeshProUGUI fifthNametxt;
    [SerializeField] TextMeshProUGUI sixthNametxt;
    [SerializeField] TextMeshProUGUI seventhNametxt;
    [SerializeField] TextMeshProUGUI eigthNametxt;
    [SerializeField] TextMeshProUGUI ninethNametxt;
    [SerializeField] TextMeshProUGUI tenthNametxt;

    List<Image> imageList = new List<Image>();
    List<TextMeshProUGUI> nameList = new List<TextMeshProUGUI>();


    [SerializeField] Sprite NMS;
    [SerializeField] Sprite UJS;
    [SerializeField] Sprite LYH;
    [SerializeField] Sprite PHA;
    [SerializeField] Sprite LHB;
    [SerializeField] Sprite LKS;
    [SerializeField] Sprite KJW;
    [SerializeField] Sprite YHJ;
    [SerializeField] Sprite KDY;
    [SerializeField] Sprite KJH;




    // Start is called before the first frame update
    void Start()
    {
        characterPull.Add("³ë¹Î¼®´Ô");
        characterPull.Add("¾öÁö¼º´Ô");
        characterPull.Add("ÀÌÀ±È£´Ô");
        characterPull.Add("¹ÚÇö¾Æ´Ô");
        characterPull.Add("ÀÌÈ£¹ü´Ô");
        characterPull.Add("ÀÌ°æ½Ä´Ô");
        characterPull.Add("±èÁö¿ø´Ô");
        characterPull.Add("¾çÇöÁö´Ô");
        characterPull.Add("±Çµµ¿µ´Ô");
        characterPull.Add("±èÀçÇù´Ô");

        for(int i =0; i< 10; i++)
        {
            imageList.Add(null);
            nameList.Add(null);
        }

        imageList[0] = firstSocket;
        imageList[1] = secondSocket;
        imageList[2] = thirdSocket;
        imageList[3] = fourthSocket;
        imageList[4] = fifthSocket;
        imageList[5] = sixthSocket;
        imageList[6] = seventhSocket;
        imageList[7] = eighthSocket;
        imageList[8] = ninthSocket;
        imageList[9] = tenthSocket;

        nameList[0] = firstNametxt;
        nameList[1] = secondNametxt;
        nameList[2] = thirdNametxt;
        nameList[3] = fourthNametxt;
        nameList[4] = fifthNametxt;
        nameList[5] = sixthNametxt;
        nameList[6] = seventhNametxt;
        nameList[7] = eigthNametxt;
        nameList[8] = ninethNametxt;
        nameList[9] = tenthNametxt;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tenGatcha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomGatch = Random.Range(0, characterPull.Count);

            switch(randomGatch)
            {
                case 0:
                    imageList[i].sprite = NMS;
                    nameList[i].text = "³ë¹Î¼®";
                    rarity(i);
                    break;

                case 1:
                    imageList[i].sprite = UJS;
                    nameList[i].text = "¾öÁö¼º";
                    rarity(i);
                    break;

                case 2:
                    imageList[i].sprite = LYH;
                    nameList[i].text = "ÀÌÀ±È£";
                    rarity(i);
                    break;

                case 3:
                    imageList[i].sprite = PHA;
                    nameList[i].text = "¹ÚÇö¾Æ";
                    rarity(i);
                    break;

                case 4:
                    imageList[i].sprite = LHB;
                    nameList[i].text = "ÀÌÈ£¹ü";
                    rarity(i);
                    break;

                case 5:
                    imageList[i].sprite = LKS;
                    nameList[i].text = "ÀÌ°æ½Ä";
                    rarity(i);
                    break;

                case 6:
                    imageList[i].sprite = KJW;
                    nameList[i].text = "±èÁö¿ø";
                    rarity(i);
                    break;

                case 7:
                    imageList[i].sprite = YHJ;
                    nameList[i].text = "¾çÇöÁö";
                    rarity(i);
                    break;

                case 8:
                    imageList[i].sprite = KDY;
                    nameList[i].text = "±Çµµ¿µ";
                    rarity(i);
                    break;

                case 9:
                    imageList[i].sprite = KJH;
                    nameList[i].text = "±èÀçÇù";
                    rarity(i);
                    break;

            }
                

            
        }
    }

    void rarity(int star)
    {
        int randomrarity = Random.Range(0, 100);

        // imageList[star]ÀÇ ÇÏÀ§¿¡¼­ ¿ÀºêÁ§Æ® Å½»ö
        Transform parent = imageList[star].transform;

        GameObject oneStar = parent.Find("oneStar")?.gameObject;
        GameObject twoStar = parent.Find("twoStar")?.gameObject;
        GameObject threeStar = parent.Find("threeStar")?.gameObject;

        // ¸ÕÀú ¸ðµÎ ºñÈ°¼ºÈ­
        if (oneStar != null) oneStar.SetActive(false);
        if (twoStar != null) twoStar.SetActive(false);
        if (threeStar != null) threeStar.SetActive(false);

        // ·¹¾îµµ ºÐ±â
        if (randomrarity <= 5)
        {
            // ¡Ú¡Ú¡Ú
            if (threeStar != null) threeStar.SetActive(true);
        }
        else if (randomrarity > 5 & randomrarity <= 10)
        {
            // ¡Ú¡Ú
            if (twoStar != null) twoStar.SetActive(true);
        }
        else
        {
            // ¡Ú
            if (oneStar != null) oneStar.SetActive(true);
        }
    }
}
