using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public float hoverScale = 0.6f; // �}�E�X�����킹���Ƃ��̊g�嗦
    private Vector3 originalScale; // �I�u�W�F�N�g�̌��̃X�P�[��

    private void Start()
    {
        originalScale = transform.localScale; // �I�u�W�F�N�g�̌��̃X�P�[����ۑ�
    }

    private void OnMouseEnter()
    {
        // �}�E�X���I�u�W�F�N�g�ɓ������Ƃ��̏���
        transform.localScale = originalScale * hoverScale; // �g�傷��
    }

    private void OnMouseExit()
    {
        // �}�E�X���I�u�W�F�N�g����o���Ƃ��̏���
        transform.localScale = originalScale; // ���̃X�P�[���ɖ߂�
    }
}
