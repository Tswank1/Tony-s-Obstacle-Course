using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] private LayerMask objectLayers;
    MeshRenderer mr;
    [ColorUsage(true, true)]
    public Color hitColor;

    public Material playerMaterial;

    public int numberOfObjectsHit { get; private set; }

    public List<GameObject> hitObjects = new List<GameObject>();

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    //Using this one for the lasers since they are triggers
    private void OnTriggerEnter(Collider other)
    {
        //Checks to see if the object is not this layer
        if ((objectLayers.value & (1 << other.gameObject.layer)) == 0)
            return;

        if (hitObjects.Exists(x => x.GetInstanceID() == other.gameObject.GetInstanceID()))
            return;

        hitObjects.Add(other.gameObject);

        OnHit();
    }

    //Use this method for the walls since they are colliders
    private void OnCollisionEnter(Collision collision)
    {
        if ((objectLayers.value & (1 << collision.gameObject.layer)) == 0)
            return;

        if (hitObjects.Exists(x => x.GetInstanceID() == collision.gameObject.GetInstanceID()))
            return;

        hitObjects.Add(collision.gameObject);

        OnHit();
    }

    public void OnHit()
    {
        Debug.Log("Hit an object");

        numberOfObjectsHit++;

        mr.material.color = playerMaterial.color;
        mr.material.DOColor(hitColor, 0.1f).OnComplete(() => mr.material.DOColor(playerMaterial.color, .4f));
    }
}
