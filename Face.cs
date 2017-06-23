﻿/*************************************************************************
* 
* 18 SIGNALS CONFIDENTIAL
* __________________
* 
*  [2013] 18 SIGNALS, LLC
*  All Rights Reserved.
* 
* NOTICE:  All information contained herein is, and remains
* the property of 18 SIGNALS, LLC and its suppliers,
* if any.  The intellectual and technical concepts contained
* herein are proprietary to 18 SIGNALS, LLC and its suppliers 
* and may be covered by U.S. and Foreign Patents, patents in process, 
* and are protected by trade secret or copyright law.
* Dissemination of this information or reproduction of this material
* is strictly forbidden unless prior written permission is obtained
* from 18 SIGNALS, LLC.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.API
{
    /// <summary>
    /// Information about a detected face on an image
    /// </summary>
    public class Face
    {
        public int topLeftX { get; set; }
        public int topLeftY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int leftEyeCenterX { get; set; }
        public int leftEyeCenterY { get; set; }
        public int rightEyeCenterX { get; set; }
        public int rightEyeCenterY { get; set; }
        public int noseTipX { get; set; }
        public int noseTipY { get; set; }
        public int noseBtwEyesX { get; set; }
        public int noseBtwEyesY { get; set; }
        public int chinTipX { get; set; }
        public int chinTipY { get; set; }
        public int leftEyeCornerLeftX { get; set; }
        public int leftEyeCornerLeftY { get; set; }
        public int leftEyeCornerRightX { get; set; }
        public int leftEyeCornerRightY { get; set; }
        public int rightEyeCornerLeftX { get; set; }
        public int rightEyeCornerLeftY { get; set; }
        public int rightEyeCornerRightX { get; set; }
        public int rightEyeCornerRightY { get; set; }
        public int rightEarTragusX { get; set; }
        public int rightEarTragusY { get; set; }
        public int leftEarTragusX { get; set; }
        public int leftEarTragusY { get; set; }
        public int leftEyeBrowLeftX { get; set; }
        public int leftEyeBrowLeftY { get; set; }
        public int leftEyeBrowMiddleX { get; set; }
        public int leftEyeBrowMiddleY { get; set; }
        public int leftEyeBrowRightX { get; set; }
        public int leftEyeBrowRightY { get; set; }
        public int rightEyeBrowLeftX { get; set; }
        public int rightEyeBrowLeftY { get; set; }
        public int rightEyeBrowMiddleX { get; set; }
        public int rightEyeBrowMiddleY { get; set; }
        public int rightEyeBrowRightX { get; set; }
        public int rightEyeBrowRightY { get; set; }
        public int nostrilLeftHoleBottomX { get; set; }
        public int nostrilLeftHoleBottomY { get; set; }
        public int nostrilRightHoleBottomX { get; set; }
        public int nostrilRightHoleBottomY { get; set; }
        public int nostrilLeftSideX { get; set; }
        public int nostrilLeftSideY { get; set; }
        public int nostrilRightSideX { get; set; }
        public int nostrilRightSideY { get; set; }
        public int lipCornerLeftX { get; set; }
        public int lipCornerLeftY { get; set; }
        public int lipLineMiddleX { get; set; }
        public int lipLineMiddleY { get; set; }
        public int lipCornerRightX { get; set; }
        public int lipCornerRightY { get; set; }
        public int pitch { get; set; }
        public int yaw { get; set; }
        public int roll { get; set; }
    }
}
