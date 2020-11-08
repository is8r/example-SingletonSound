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
        public AudioClip[] audios;

        //外部から呼び出す
        public void Play(int n = 0)
        {
            //オーディオソースを呼び出す
            AudioSource audiosource = GetComponent<AudioSource>();

            //再生中のスクリプトを停止する
            audiosource.Stop();

            //オーディオソースを再生する
            audiosource.PlayOneShot(audios[n]);
        }
    }
}
