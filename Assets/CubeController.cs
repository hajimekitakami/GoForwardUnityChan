using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //�L���[�u�̈ړ����x
    private float speed = -12;

    //���ňʒu
    private float deadLine = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //�L���[�u���n�ʂɏՓ˂��鎞�Ɛςݏd�Ȃ鎞�Ɍ��ʉ���炷
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Cube")
        {
            GetComponent<AudioSource>().Play();
        }
        //���j�e�B�����ƏՓ˂����Ƃ��ɂ͌��ʉ���炳�Ȃ�
        /*else if (other.gameObject.tag == "UnityChan")
        {
            GetComponent<AudioSource>().mute = true;
        }*/
    }
}
