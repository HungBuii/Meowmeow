using UnityEngine;
using System.Collections.Generic;
using System;
namespace Manager
{
    public class SoundManager : Singleton<SoundManager>
    {
        [SerializeField] private List<Sound> sounds;
        //List<Sound> sounds;
        public AudioSource background;
        public AudioSource SFX;
        public AudioSource laugh;


        public void PlayBackground(SoundName soundName)
        {
            background.loop = true;
            background.Play();
        }
        public void PlaySFX(SoundName soundName)
        {
            foreach (var sound in sounds)
            {
                if (sound.soundName == soundName)
                {
                    SFX.clip = sound.audioClip;
                    SFX.Play();
                }
            }
        }
        public void PlayLaugh(SoundName soundName)
        {
            foreach (var sound in sounds)
            {
                if (sound.soundName == soundName)
                {
                    laugh.clip = sound.audioClip;
                    laugh.Play();
                }
            }
        }

    }

    [Serializable]
    public class Sound
    {
        public SoundName soundName;
        public AudioClip audioClip;
    }

    public enum SoundName
    {
        Theme,
        click,
        Win,
        Lose,
        Laugh,
    }
}
