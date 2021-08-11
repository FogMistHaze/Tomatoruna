using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance;

    public enum SE
    {
        Menu_Select,
        Menu_Startup,
        Decision,
        Cancel,
        TomatoAttack,
        CoinAttack
    }

    [Tooltip("効果音のAudio Clipを、SEの列挙子と同じ順番で設定してください。"), SerializeField]
    AudioClip[] selist;

    AudioSource audioSource;

    private void Awaka()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.selist[(int)se]);
    }
}
