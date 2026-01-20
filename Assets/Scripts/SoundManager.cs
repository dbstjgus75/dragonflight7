using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //½Ì±ÛÅæ
    public static SoundManager instance; // ½Ì±ÛÅæ º¯¼ö

    AudioSource myAudio; //AudioSource ÄÄÆ÷³ÍÆ® º¯¼ö¸¦ ´ãÀ½.
    public AudioClip soundBullet; // Àç»ýÇÒ ¼Ò¸® º¯¼ö
    public AudioClip soundDie; // Á×´Â ¼Ò¸®


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;   
        }
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }

    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}
