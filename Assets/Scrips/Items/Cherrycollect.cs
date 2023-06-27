using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cherrycollect : MonoBehaviour
{
    public int countCherry = 0;
    [SerializeField] private Text CherryUI;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            SoundManager.Instance.PlayVFXMusic("CollectItem");
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("Cheery", countCherry);
            countCherry++;
            CherryUI.text = "Cherry : " + countCherry;
        }
    }
}
