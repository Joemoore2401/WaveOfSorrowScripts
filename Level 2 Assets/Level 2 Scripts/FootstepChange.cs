using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class FootstepChange : MonoBehaviour
{
    public List <GroundType> GroundTypes = new List <GroundType>();
    public FirstPersonController FPS;
    public string currentground;


    void Start()
    {
        setGroundType(GroundTypes[0]);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Water")
            setGroundType(GroundTypes[1]);
        else if (hit.transform.tag == "Ground")
            setGroundType(GroundTypes[2]);
        else if (hit.transform.tag == "WaterSlow")
            setGroundType(GroundTypes[3]);
        else if (hit.transform.tag == "Underground")
            setGroundType(GroundTypes[4]);
        else 
            setGroundType(GroundTypes[0]);
    }

    public void setGroundType(GroundType ground)
    {
        if (currentground != ground.name)
        {
            FPS.m_FootstepSounds = ground.footstepsounds;
            FPS.m_WalkSpeed = ground.walkSpeed;
            FPS.m_RunSpeed = ground.runSpeed;
            currentground = ground.name;

        }
    }
[System.Serializable]
public class GroundType
    {
        public string name;
        public AudioClip[] footstepsounds;
        public float walkSpeed = 5; //defaultSpeeds
        public float runSpeed = 5;
    }

}
