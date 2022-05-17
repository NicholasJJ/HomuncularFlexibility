using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffHand : MonoBehaviour
{
    [SerializeField] Rigidbody hand;
    [SerializeField] Transform target;
    public bool Left;

    RelativePositions rp;
    // Start is called before the first frame update
    void Start()
    {
        rp = GameObject.FindGameObjectWithTag("Player").GetComponent<RelativePositions>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Left)
        {
            target.localPosition = rp.relativeLPos;
            target.localRotation = rp.relativeLRot;
        }
        else
        {
            target.localPosition = rp.relativeRPos;
            target.localRotation = rp.relativeRRot;
        }

        
    }

    private void FixedUpdate()
    {
        hand.velocity = (target.position - hand.position) / Time.fixedDeltaTime;
        hand.MoveRotation(target.rotation);
    }
}
