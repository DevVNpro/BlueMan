using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    protected static SoundManager instance;
    public static SoundManager Instance => instance;
    private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        SoundManager.instance = this;
        DontDestroyOnLoad(gameObject);
        this.BackgroundMusic();
    }
 
    protected void BackgroundMusic()
    {
         PlayThemeMusic("BackgroundMusic1");
    }


    [SerializeField] protected AudioSource themeSource;
    [SerializeField] protected AudioSource vfxSource;

    [SerializeField] protected List<Music> themSources;
    [SerializeField] protected List<Music> vfxSources;


    public void PlayThemeMusic(string name)
    {
        foreach(Music music in themSources)
        {
            if(name == music.name)
            {
                themeSource.clip = music.clip;
                themeSource.Play();
            }

        }
    }
    public void PlayVFXMusic(string name)
    {
        foreach (Music music in vfxSources)
        {
            if (name == music.name)
            {
                vfxSource.clip = music.clip;
                vfxSource.Play();
            }

        }
    }

}
