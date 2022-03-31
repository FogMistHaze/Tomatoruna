using UnityEngine;
public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance;

    public enum SE
    {
        Decision,
        CoinAttack,
        TomatoAttack,
        AppleAttack,
    }

    [SerializeField]
    AudioClip[] seList = null;
    AudioSource audioSource;

    private void Awake()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }
    
    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.seList[(int)se]);
    }
}
