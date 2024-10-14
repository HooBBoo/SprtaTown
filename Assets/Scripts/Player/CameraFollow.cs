﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class CameraFollow : MonoBehaviour
    {
        private Vector3 offset = new Vector3(0f, 0f, -10f);  // 카메라와 타겟과의 차이 -10만큼 뒤에 위치하도록 고정
        private float smoothTime = 0.25f;  //  카메라가 목표 위치에 도달하는 데 걸리는 시간(부드러운 움직임을 위해서), 값이 작을수록 빠르고 클수록 느림.
        private Vector3 velocity = Vector3.zero;

        [SerializeField] private Transform target;

        private void Update()
        {
            Vector3 targetPosition = target.position + offset;  //  거리유지를 위해 타겟의 위치에 고정된 offset값을 더함
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime); //  SmoothDamp가 부드러운 감속운동을 하게 함
                                                                                                                   //  ref velocity: 참조로 넘겨진velocity 값으로 카메라 속도 관리
        }
    }
}
