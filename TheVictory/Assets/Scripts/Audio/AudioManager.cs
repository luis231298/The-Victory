using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public bool muteAudio = false;

    public void MuteAudio()
    {
        AudioListener.pause = muteAudio == true;
    }
    
}
