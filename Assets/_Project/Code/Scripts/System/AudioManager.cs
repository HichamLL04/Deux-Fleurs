using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource musicSource;
    [SerializeField] AudioClip loopClip;
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        PLayAudio(loopClip);
    }

    void Update()
    {
        
    }

    public void PlayOnce(AudioClip audioClip)
    {
        musicSource.PlayOneShot(audioClip);
    }

    public void PLayAudio(AudioClip audioClip)
    {
        musicSource.clip = audioClip;
        musicSource.Play();
    }
}
