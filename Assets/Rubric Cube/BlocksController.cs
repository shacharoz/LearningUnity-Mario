using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksController : MonoBehaviour
{
    public Transform AllBlock;
    public Transform TopParent;
    public Transform LeftParent;

    public List<Transform> Blocks;


    void Start()
    {

    }

    /// <summary>
    /// reset the parent of all blocks to save the last position of it. 
    /// called from the Animator state beavior
    /// </summary>
    private void ResetBlocks()
    {
        foreach (Transform t in Blocks)
        {
            t.SetParent(AllBlock);
        }
    }

    public void SetHorizontalGroups()
    {
        //top
        foreach (Transform t in Blocks)
        {
            if (Mathf.RoundToInt( t.localPosition.y) == 1)
            {
                t.parent = TopParent;
            }
        }
    }

    public void SetVerticalGroups()
    {
        //left
        foreach (Transform t in Blocks)
        {
            if (Mathf.RoundToInt(t.localPosition.x) == 1)
            {
                t.parent = LeftParent;
            }
        }
    }
}