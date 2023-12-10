using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confi : MonoBehaviour
{
    #region Skin
    private const string stringId = "Skin_ID";
    private static int oldSkin;
    //(use when institet  play in map)
    public static int GetCurrentIDSkin()
    {
        return PlayerPrefs.GetInt(stringId, 0);
    }

    //(use when try skin by ads )
    public static void SetCurrentIDSkin(int id)
    {

        PlayerPrefs.SetInt(stringId, id);
        PlayerPrefs.Save();

    }
    //(use when go to main or go to home)
    public static int GetOldSkinId()
    {
        if (PlayerPrefs.HasKey(stringId))
        {
            oldSkin = PlayerPrefs.GetInt(stringId);
        }
        return oldSkin;
    }
    // use when buy a new skin in shop
    public static void SetSkinOwned(int id)
    {
        if (PlayerPrefs.HasKey(stringId + id)) return;
        PlayerPrefs.SetInt(stringId + id, 1);
        PlayerPrefs.Save();
    }
    // skin has bought(use in main to show list skin buy)
    public static bool GetSkinOwned(int id)
    {
        if (PlayerPrefs.HasKey(stringId + id))
        {
            return true;
        }
        return false;
    }
    #endregion
}
