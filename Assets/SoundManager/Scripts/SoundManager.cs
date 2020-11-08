/*

hotwto:
SoundManager.Instance.Play(0);

*/

using UnityEngine;

namespace SoundManagement
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : SoundManagement.SingletonMonoBehaviour<SoundManager>
    {
        //音源を登録する配列
        public AudioClip[] seClips;
        public AudioClip[] bgmClips;

        //オーディオソース
        public AudioSource seAudioSource;
        public AudioSource bgmAudioSource;

        //外部から呼び出す
        public void Play(int n = 0)
        {
            //再生中のスクリプトを停止する
            seAudioSource.Stop();

            //オーディオソースを再生する
            seAudioSource.PlayOneShot(seClips[n]);
        }

        //外部から呼び出す
        public void PlayBgm(int n = 0)
        {
            //再生中のスクリプトを停止する
            bgmAudioSource.Stop();

            //オーディオソースを再生する
            bgmAudioSource.PlayOneShot(bgmClips[n]);
        }
    }
}
