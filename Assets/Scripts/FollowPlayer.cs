using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private NavMeshAgent2D _agent; //NavMeshAgent2Dを使用するための変数
    [SerializeField] private Transform target; //追跡するターゲット

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent2D>(); //agentにNavMeshAgent2Dを取得
    }

    private void Update()
    {
        _agent.destination = target.position; //agentの目的地をtargetの座標にする
        //agent.SetDestination(target.position); //こっちの書き方でもオッケー
    }
}