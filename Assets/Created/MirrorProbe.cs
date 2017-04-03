using UnityEngine;
using System.Collections;

public class MirrorProbe : MonoBehaviour{

 public Transform plane;
 public Transform character;
 public ReflectionProbe myProbe;
 public Vector3 playerLocalPos;

 void Start(){
  myProbe = GetComponent<ReflectionProbe> ();
 }

 void Update () {

  playerLocalPos = plane.InverseTransformPoint(character.position);
  playerLocalPos = new Vector3(
   playerLocalPos.x,
   playerLocalPos.y,
   -playerLocalPos.z
  );

  transform.position = plane.TransformPoint(playerLocalPos);

 }
}﻿
