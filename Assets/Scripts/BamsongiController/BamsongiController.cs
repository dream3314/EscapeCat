using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rbody;
    private ParticleSystem particleSystem;

    void Start()
    {
        //this.gameObject.GetComponent<Rigidbody>();
        this.rbody = GetComponent<Rigidbody>();
        this.particleSystem = this.GetComponent<ParticleSystem>();
        this.rbody.AddForce(new Vector3 (-2000, 200, 0));
        this.Shoot();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogFormat("OnCollisionEnter: {0}", collision.gameObject.name);
        this.rbody.isKinematic = true;

        //��ƼŬ�ý��� ������Ʈ �����ؼ� Play�޼��� ȣ��
        this.particleSystem.Play();
    }

    public void Shoot()
    {
        Debug.Log("Shoot");
    }


}
