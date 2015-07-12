using UnityEngine;
using System.Collections;
/// <summary>
/// 脚本功能：角色看着飞舞的蝴蝶
/// 添加对象：角色
/// 创建时间：2015年7月11日 duzixi.com
/// 知识要点：
/// 1. Animator.SetLookAtWeight()
/// 2. Animator.SetLookAtPosition()
/// </summary>
public class LookAtMouse : MonoBehaviour {

	Animator animator;                                      // 角色动画组件
	public Transform butterFly;                             // 飞舞的蝴蝶

	void Start () {
		animator = GetComponent<Animator>();                // 获取角色动画组件
	}

	void Update () {
		// 时刻监测鼠标打在角色面前透明平面的点
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)) {
			print (hit.point);
			butterFly.position = hit.point;                 // 设置蝴蝶位置

			// 设置上半身朝向目标的权重： 整体、身体、头部、眼镜
			animator.SetLookAtWeight(1, 0.1f, 0.8f, 0.9f);  
			animator.SetLookAtPosition(hit.point);          // 设置所看目标位置
		}
		butterFly.LookAt(transform);                        // 蝴蝶时刻看着角色
	}
}
