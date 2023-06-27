using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rid;
    void Start()
    {
        anim = GetComponent<Animator>();
        rid = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("Trap")){
            SoundManager.Instance.PlayVFXMusic("Death");
            Die();
        }
    }
    private void Die()
    {
        anim.SetTrigger("death");
        rid.bodyType = RigidbodyType2D.Static;
    }
    //Animation Event 
    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
