using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="SkinData", menuName = "CreateSkinData")]
public class SkinData : ScriptableObject
{
    [SerializeField]
   public List<SkinInfo> skinDatas;
}
[System.Serializable]
public class SkinInfo
{
    public TypeSkin typeSkin;
    public GameObject skin;
    public string Name;
    public int Price;
    public int Id;
   // public RuntimeAnimatorController animator;
}
public enum TypeSkin
{
    Recuse,
    Coin,
    Premium,
}


