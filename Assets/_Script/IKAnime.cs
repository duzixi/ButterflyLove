using UnityEngine;
using System.Collections;
/// <summary>
/// 脚本功能：通过空对象位置控制IK动画
/// 添加对象：UnityChan
/// 创建时间：2015年7月8日
/// 知识要点：
/// 1. IK动画
/// </summary>
public class IKAnime : MonoBehaviour {

	Animator animator;
	public Transform rightHandPos;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// IK动画响应方法
	void OnAnimatorIK() {
		// 设置右手权重
		animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
		animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
		// 设置右手位置
		animator.SetIKPosition(AvatarIKGoal.RightHand, 
		                       rightHandPos.position);
		animator.SetIKRotation(AvatarIKGoal.RightHand,
		                       rightHandPos.rotation);
	}
}
