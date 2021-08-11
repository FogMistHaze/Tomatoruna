using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinyAudio : MonoBehaviour
{
    public static TinyAudio Instance;

    /// <summary>
    /// seListに設定する効果音の種類を以下に定義します。
    /// </summary>
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

    /// <summary>
    /// SEで指定した効果音を再生します。
    /// </summary>
    /// <param name="se">鳴らしたい効果音</param>
    public static void PlaySE(SE se)
    {
        Instance.audioSource.PlayOneShot(Instance.selist[(int)se]);
    }
}
