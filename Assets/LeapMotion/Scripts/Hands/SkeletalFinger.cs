﻿/******************************************************************************\
* Copyright (C) Leap Motion, Inc. 2011-2014.                                   *
* Leap Motion proprietary. Licensed under Apache 2.0                           *
* Available at http://www.apache.org/licenses/LICENSE-2.0.html                 *
\******************************************************************************/

using UnityEngine;
using System.Collections;
using Leap;

/** 
 * A finger object consisting of discrete, component parts for each bone.
 * 
 * The graphic objects can include both bones and joints, but both are optional.
 */
public class SkeletalFinger : FingerModel
{

    /** Initializes the finger bones and joints by setting their positions and rotations. */
    public override void InitFinger()
    {
        SetPositions();
    }

    /** Updates the finger bones and joints by setting their positions and rotations. */
    public override void UpdateFinger()
    {
        SetPositions();
    }

    protected void SetPositions()
    {
        for (int i = 0; i < bones.Length; ++i)
        {
            if (bones[i] != null)
            {
                bones[i].transform.position = GetBoneCenter(i);
                bones[i].transform.rotation = GetBoneRotation(i);
            }
        }

        for (int i = 0; i < joints.Length; ++i)
        {
            if (joints[i] != null)
            {
                joints[i].transform.position = GetJointPosition(i + 1);
                joints[i].transform.rotation = GetBoneRotation(i + 1);
            }
        }
        if (this.fingerType == Finger.FingerType.TYPE_INDEX)
        {
            Vector3 local_point = this.finger_.TipPosition.ToUnity(this.mirror_z_axis_);
            //local_point = this.controller_.transform.TransformPoint(local_point) + (this.offset_ * 1000);
            ExtractPoint.LogPoint(local_point);
            ExtractPoint.TrackBoneFinger(this.finger_.TipPosition.ToUnityScaled(this.mirror_z_axis_));
        }
    }
}
