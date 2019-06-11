using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : MonoBehaviour
{

    public List<Transform> Slots;
    public GameObject Projectile;
    AudioSource audiosrc;

    public void Fire()
    {
        audiosrc = GetComponent<AudioSource>();
        audiosrc.Play();
        Slots.ForEach(slot =>
       {
           Instantiate(Projectile,
               slot.transform.position,
               slot.transform.rotation
            );
       });
    }

}
