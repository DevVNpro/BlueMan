using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

abstract class RxManager
{
    #region UI
    public static readonly Subject<Action> ClickButtonShop = new Subject<Action>();
    public static readonly Subject<Action> ClickButtonHomeShop = new Subject<Action>();




    #endregion

}
