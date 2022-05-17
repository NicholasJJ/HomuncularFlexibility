using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativePositions : MonoBehaviour
{
    [SerializeField] Transform Camera;
    [SerializeField] Transform LHand;
    [SerializeField] Transform RHand;
    [SerializeField] Transform LHandBase;
    [SerializeField] Transform RHandBase;

    public Vector3 relativeRPos;
    public Quaternion relativeRRot;
    public Vector3 relativeLPos;
    public Quaternion relativeLRot;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        relativeLPos = LHand.position - LHandBase.position;
        relativeLRot = LHand.localRotation;
        relativeRPos = RHand.position - RHandBase.position;
        relativeRRot = RHand.localRotation;
    }
}
