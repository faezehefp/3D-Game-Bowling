using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    //؟؟؟
    [SerializeField] private AudioSource ballSound;
    //برای نگهداری کامپوننت ریجید بادی توپ
    [SerializeField] Rigidbody BallRigidBody;

    //تعیین توان و قدرت پرتاب توپ
    [SerializeField] float Power;

    void Start()
    {
        //به دست آوردن کامپوننت ریجیدبادی
        BallRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //اگر کلید Enter فشرده شده بود
        if(Input.GetKeyDown(KeyCode.Return))
        {
            //نیرویی به سمت جلو به توپ اضافه می‌شود
            BallRigidBody.AddForce(Vector3.forward * Power);
            //؟؟؟
            ballSound.Play();
        }
    }
}