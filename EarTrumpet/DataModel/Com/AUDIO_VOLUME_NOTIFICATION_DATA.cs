﻿using System;
using System.Runtime.InteropServices;

namespace EarTrumpet.DataModel.Com
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AUDIO_VOLUME_NOTIFICATION_DATA
    {
        public Guid guidEventContext;
        public int bMuted;
        public float fMasterVolume;
        public uint nChannels;
        public float[] afChannelVolumes;
    }
}