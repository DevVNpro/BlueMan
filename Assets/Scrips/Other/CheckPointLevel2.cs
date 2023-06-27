using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointLevel2 : CheckPoint
{
    private void Start()
    {
        this.ResetCheckCountCherry();
    }
    protected override void ResetCheckCountCherry()
    {
        this.checkCountCherry = 18;
    }
    protected override void NextLevel()
    {
        base.NextLevel();
        SoundManager.Instance.PlayThemeMusic("BackgroundMusic1");
    }
}
