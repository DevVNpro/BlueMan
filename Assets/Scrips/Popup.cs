using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using DG.Tweening;
using UnityEngine.UI;
using System;
public class Popup : MonoBehaviour
{
    [InfoBox("If this pop up is full screen, it has animation to do when opening and closing popup ")]
    public bool fullScreen = true;

    [BoxGroup("Animation Popup Details")]
    [HideIfGroup("Animation Popup Details/fullScreen")]
    public CanvasGroup canvasGroup;
    [HideIfGroup("Animation Popup Details/fullScreen")]
    public float animTime;

    public virtual void  OpenPanel()
    {
        if (!fullScreen)
        {
            OpenPopup();
            return;

        }
        gameObject.SetActive(true);

    }
    public virtual void ClosePanel()
    {
        if (!fullScreen)
        {
            ClosePopup();
            return;
        }
        gameObject.SetActive(false);
    }

    public virtual void  OpenPopup(Action  action = null)
    {
        DOTween.CompleteAll();
        canvasGroup.GetComponent<RectTransform>().localScale = Vector3.zero;
        canvasGroup.GetComponent<RectTransform>().DOScale(1f, animTime)
        .SetEase(Ease.OutBack)
        .OnStart(delegate
        {
            canvasGroup.interactable = false;
            gameObject.SetActive(true);
        })
        .OnComplete(delegate
        {
            canvasGroup.interactable = true;
            action?.Invoke();
        });
    }
    public virtual void ClosePopup(Action action = null)
    {
        DOTween.CompleteAll();
        canvasGroup.GetComponent<RectTransform>().DOScale(0f, animTime)
        .SetEase(Ease.InBack)
        .OnStart(delegate {
            canvasGroup.interactable = false;
        })
        .OnComplete(delegate
        {
            gameObject.SetActive(false);
            action?.Invoke();
        }); 
    }





}
