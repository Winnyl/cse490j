using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableTyrantPlayer : Selectable
{
    [SerializeField]
    private Material def, hover, selected;
    private bool isSelected = false;
    public Animator anim;
    public int poseNum;
    public AudioSource sound;

    // This method should set the pose parameter in the animator to poseNum 
    public override GameObject OnSelect()
    {
        isSelected = true;
        // TODO:
        // Set the animator pose value here:
        // Set the object's mesh renderer to the selected material
        // Play the Tyrant's sound clip
        poseNum = this.poseNum;
        gameObject.GetComponent<MeshRenderer>().material = this.gameObject.GetComponent<MeshRenderer>().material;
        sound.Play();



        return this.gameObject;
    }

    public override GameObject OnHover()
    {
        if (gameObject.GetComponent<MeshRenderer>().material != hover && !isSelected)
        {
            gameObject.GetComponent<MeshRenderer>().material = hover;
        }
        return this.gameObject;
    }

    public override void OnDeselect()
    {
        isSelected = false;
        // TODO:
        // Set the animator's pose value to 0
        // Set the object's mesh renderer to the def material
        poseNum = 0;
        gameObject.GetComponent<MeshRenderer>().material = def;


    }
}
