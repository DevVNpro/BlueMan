using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;
using UniRx;

public class MainUiManager : MonoBehaviour
{
   [SerializeField] private GameObject[] panels;


    private void Awake()
    {
        RxManager.ClickButtonShop.Subscribe(delegate (Action action)
        {
            CloseAllPanel();
            ShowPanel<ShopPanel>();
            action?.Invoke();
        }).AddTo(this);
        RxManager.ClickButtonHomeShop.Subscribe(delegate (Action action)
        {
            CloseAllPanel();
            ShowPanel<HomePanel>();
            action?.Invoke();
        }).AddTo(this);


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void ShowPanel<T>() where T : Popup
    {
        foreach (var a in panels)
        {
            var panel = a.GetComponent<T>();
            Debug.Log("1");
            if (panel == null) continue;
            panel.OpenPanel();
        }
    }
    private void ClosePanel<T>() where T : Popup
    {
        foreach(var a in panels)
        {
            var panel = a.GetComponent<T>();
            if (panel == null) continue;
            panel.ClosePanel();
        }
    }
    private void CloseAllPanel()
    {
        foreach (var t in panels)
        {
            var panel = t.GetComponent<Popup>();
            if(panel != null)
            {
                t.SetActive(false);
            }


        }

    }

    private T GetPanel<T>() where T : Popup
    {
        foreach(var a in panels)
        {
            var panel = a.GetComponent<T>();
            if (panel == null) continue;
            return panel;

        }
        return null;
    }

}
