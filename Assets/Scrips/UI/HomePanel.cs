using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using Sirenix.OdinInspector;

public class HomePanel : Popup
{
    [Header("Ref Button")]
    [SerializeField] private Button shopButton;
    [InlineEditor]
    public SkinData data;
    private void Awake()
    {
        shopButton.onClick.AddListener(OnClickButtonShop);

    }

    void Start()
    {
        ShowSkinUI();

    }
    private void OnClickButtonShop()
    {
        RxManager.ClickButtonShop.OnNext(delegate { });
    }
    private void ShowSkinUI()
    {
        foreach (var skin in data.skinDatas)
        {
            if (!ConfigData.GetSkinOwned(skin.Id))
            {
                Debug.Log("Khongco");
            }

        }

    }




}
