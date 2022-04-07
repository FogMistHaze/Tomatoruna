using UnityEngine;

public class TinyAudio : MonoBehaviour
{
    [SerializeField]
    AudioClip[] seList = null;

    [SerializeField]
    AudioClip[] bgmList = null;

    AudioSource audioSource;

    public static TinyAudio Instance;

    public enum SE
    {
        Decision,
        CoinAttack,
        TomatoAttack,
        AppleAttack,
    }

    public enum BGM
    {
        Gameover,
        Clear
    }

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    
    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.seList[(int)se]);
    }

    public static void StopBGM()
    {
        Instance.audioSource.Stop();
    }

    public static void PlayBGM(BGM bgm)
    {
        StopBGM();
        Instance.audioSource.clip = Instance.bgmList[(int)bgm];
        Instance.audioSource.Play();
    }

}
