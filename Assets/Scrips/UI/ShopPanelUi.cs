using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopPanelUi : MonoBehaviour
{
    [Header("Shop Data")]
    [SerializeField] private SkinData dataSkin;
    [SerializeField] private GameObject ButtonSkin;
    [SerializeField] private Transform ScrollView;
    [Header("ButtonRef")]
    [SerializeField] private Button ButtonBackHome;

    private void Start()
    {

        ShowUiSkin();

    }
    public void ShowUiSkin()
    {
        foreach(var skin in dataSkin.skinDatas)
        {
            if(skin.typeSkin == TypeSkin.Coin || skin.typeSkin == TypeSkin.Recuse)
            {
                GameObject NewSkin = Instantiate(ButtonSkin, ScrollView);
                NewSkin.transform.GetChild(0).GetComponent<Image>().sprite = skin.skin.GetComponent<SpriteRenderer>().sprite;
            }

        }



    }




}
