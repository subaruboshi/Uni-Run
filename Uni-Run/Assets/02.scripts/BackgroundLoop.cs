using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ���� ������ �̵��� ����� ������ ������ ���ġ�ϴ� ��ũ��Ʈ
public class BackgroundLoop : MonoBehaviour
{
    private float width; // ����� ���� ����
    private void Awake()
    {
        // BoxCollider2D ������Ʈ�� Size �ʵ��� x ���� ���� ���̷� ���
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }
    
   private void Update()
    {
        // ���� ��ġ�� �������� �������� width �̻� �̵����� �� ��ġ�� ���ġ
        if (transform.position.x <= -width)
        {
            Reposition();
        
        }
    }

    // ��ġ�� ���ġ�ϴ� �޼���
    private void Reposition()
    {
        // ���� ��ġ���� ���������� ���� ���� * 2��ŭ �̵�
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
