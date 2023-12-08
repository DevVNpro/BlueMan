using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rid;
    bool flat;
    void Start()
    {
        anim = GetComponent<Animator>();
        rid = GetComponent<Rigidbody2D>();
        flat = true;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap") || (collision.gameObject.CompareTag("enemy") && (collision.gameObject.transform.position.y >=transform.position.y)))
        {
            if (flat)
            {
            SoundManager.Instance.PlayVFXMusic("Death");
            Die();
                flat = false;
            }
        }
    }
    private void Die()
    {
        
        anim.SetTrigger("death");
        rid.bodyType = RigidbodyType2D.Static;
        transform.GetComponent<Collider2D>().enabled = false;
    }
    //Animation Event 
    protected void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
