using UnityEngine;
/// <summary>
/// 플레이어 오브젝트에 부착하는 C# 스크립트입니다.
/// </summary>
public class PlayerMover : MonoBehaviour
{
    #region 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 인스펙터 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓
    [Header("필수 요소 등록")]
    [SerializeField] private Transform _player;

    [Header("사용자 정의 설정")]
    [SerializeField] private float _moveSpeed = 10f;

    #endregion

    private void Update()
    {
        if (_player == null)
            return;

        float v = 0f, h = 0f;
        if (Input.GetKey(KeyCode.W)) v += 1f;
        if (Input.GetKey(KeyCode.S)) v -= 1f;
        if (Input.GetKey(KeyCode.A)) h += 1f;
        if (Input.GetKey(KeyCode.D)) h -= 1f;

        if(h != 0f || v != 0f) {
            Vector3 direction = (_player.forward * v + _player.right * h).normalized;
            _player.transform.position += direction * _moveSpeed * Time.deltaTime;
        }
    }
}
