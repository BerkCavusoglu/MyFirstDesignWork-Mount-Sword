using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using RPG.Controller;


namespace RPG.Cinematics
{
    
    public class CinematicControlRemover : MonoBehaviour
    {

        GameObject player;

        void Start()
        {
            player = GameObject.FindWithTag("Player");
            GetComponent<PlayableDirector>().played += DisableControl;
            GetComponent<PlayableDirector>().stopped += EnableControl;
        }

        void EnableControl(PlayableDirector pd)
        {
            player.GetComponent<PlayerController>().enabled = true;
        }

        void DisableControl(PlayableDirector pd)
        {
            player.GetComponent<PlayerController>().enabled = false;
        }
    }
}

