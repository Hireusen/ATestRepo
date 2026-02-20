using UnityEngine;
/// <summary>
/// ~ 스크립트에 부착하는 C# 스크립트입니다.
/// ~ 오브젝트에 부착하는 C# 스크립트입니다.
/// ~ 합니다.
/// </summary>
public class AAD : MonoBehaviour
{
    #region 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 인스펙터 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓
    [Header("필수 요소 등록")]
    [SerializeField] private Transform _player;

    [Header("인스펙터 │ 매니저 │ 자동 등록")]
    [SerializeField] private Transform _target;

    [Header("사용자 정의 설정")]
    [SerializeField] private Vector3 _offset = new Vector3(0f, 0f, 0f);
    #endregion

    #region 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 내부 변수 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓

    #endregion

    #region 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 내부 메서드 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓
    // 인스펙터 유효성 검사
    public void Verification() {

    }
    // 외부에 전달할 데이터 생성
    public void DataBuilder() {

    }
    // 스크립트 내부 변수 초기화
    public void Initialize() {

    }
    // 마스터 매니저의 Update() 에서 호출할 메서드
    public void RunBeforeFrame() {

    }
    // 마스터 매니저의 LateUpdate() 에서 호출할 메서드
    public void RunAfterFrame() {

    }
    #endregion

    #region 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓 메시지 함수 〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓

    #endregion
}
