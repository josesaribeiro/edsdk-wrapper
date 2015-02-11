﻿using System;

namespace EDSDKWrapper.Framework.Enums
{
    /// <summary>
    /// Indicates the shutter speed.
    /// </summary>
    /// <remarks>Values labeled "__1_3" represent property values when the step set in the Custom Function is 1/3.</remarks>
    public enum ShutterSpeed : uint
    {
        Bulb = 0x0c,
        TV_30_Seconds = 0x10,
        TV_25_Seconds = 0x13,
        TV_20_Seconds = 0x14,
        TV_20_Seconds__1_3 = 0x15,
        TV_15_Seconds = 0x18,
        TV_13_Seconds = 0x1B,
        TV_10_Seconds = 0x1C,
        TV_10_Seconds__1_3 = 0x1D,
        TV_8_Seconds = 0x20,
        TV_6_Seconds__1_3 = 0x23,
        TV_6_Seconds = 0x24,
        TV_5_Seconds = 0x25,
        TV_4_Seconds = 0x28,
        TV_3_2_Seconds = 0x2B,
        TV_3_Seconds = 0x2C,
        TV_2_5_Seconds = 0x2D,
        TV_2_Seconds = 0x30,
        TV_1_6_Seconds = 0x33,
        TV_1_5_Seconds = 0x34,
        TV_1_3_Seconds = 0x35,
        TV_1_Seconds = 0x38,
        TV_0_8_Seconds = 0x3B,
        TV_0_7_Seconds = 0x3C,
        TV_0_6_Seconds = 0x3D,
        TV_0_5_Seconds = 0x40,
        TV_0_4_Seconds = 0x43,
        TV_0_3_Seconds = 0x44,
        TV_0_3_Seconds__1_3 = 0x45,
        TV_4 = 0x48,
        TV_5 = 0x4B,
        TV_6 = 0x4C,
        TV_6__1_3 = 0x4D,
        TV_8 = 0x50,
        TV_10__1_3 = 0x53,
        TV_10 = 0x54,
        TV_13 = 0x55,
        TV_15 = 0x58,
        TV_20__1_3 = 0x5B,
        TV_20 = 0x5C,
        TV_25 = 0x5D,
        TV_30 = 0x60,
        TV_40 = 0x63,
        TV_45 = 0x64,
        TV_50 = 0x65,
        TV_60 = 0x68,
        TV_80 = 0x6B,
        TV_90 = 0x6C,
        TV_100 = 0x6D,
        TV_125 = 0x70,
        TV_160 = 0x73,
        TV_180 = 0x74,
        TV_200 = 0x75,
        TV_250 = 0x78,
        TV_320 = 0x7B,
        TV_350 = 0x7C,
        TV_400 = 0x7D,
        TV_500 = 0x80,
        TV_640 = 0x83,
        TV_750 = 0x84,
        TV_800 = 0x85,
        TV_1000 = 0x88,
        TV_1250 = 0x8B,
        TV_1500 = 0x8C,
        TV_1600 = 0x8D,
        TV_2000 = 0x90,
        TV_2500 = 0x93,
        TV_3000 = 0x94,
        TV_3200 = 0x95,
        TV_4000 = 0x98,
        TV_5000 = 0x9B,
        TV_6000 = 0x9C,
        TV_6400 = 0x9D,
        TV_8000 = 0xA0,

        /// <summary>
        /// Not valid/no settings changes
        /// </summary>
        Unknown = 0xffffffff,
    }
}