using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopPanel : Popup
{
    [Header("Shop Data")]
    [SerializeField] private SkinData dataSkin;
    [SerializeField] private GameObject ButtonSkin;
    [SerializeField] private Transform ScrollView;
    [Header("ButtonRef")]
    [SerializeField] private Button ButtonBackHome;
    private void Awake()
    {
        ButtonBackHome.onClick.AddListener(ClickButtonHome);
    }
    private void ClickButtonHome()
    {
        RxManager.ClickButtonHomeShop.OnNext(delegate { });
    }


    private void Start()
    {

        ShowUiSkin();

    }
    public void ShowUiSkin()
    {
        foreach(var skindata in dataSkin.skinDatas)
        {
            if(skindata.typeSkin == TypeSkin.Coin || skindata.typeSkin == TypeSkin.Recuse)
            {
                GameObject newSkin = Instantiate(ButtonSkin, ScrollView);
                newSkin.transform.GetChild(0).GetComponent<Image>().sprite = skindata.skin.GetComponent<Image>().sprite;
                newSkin.transform.GetChild(0).GetComponent<Animator>().runtimeAnimatorController = skindata.skin.GetComponent<Animator>().runtimeAnimatorController;
                newSkin.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = skindata.Price.ToString();
            }

        }



    }




}
