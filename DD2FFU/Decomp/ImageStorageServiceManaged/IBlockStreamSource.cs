﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.WindowsPhone.Imaging.IBlockStreamSource
// Assembly: ImageStorageServiceManaged, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b3f029d4c9c2ec30
// MVID: BF244519-1EED-4829-8682-56E05E4ACE17
// Assembly location: C:\Users\gus33000\source\repos\DD2FFU\DD2FFU\libraries\imagestorageservicemanaged.dll

namespace Decomp.Microsoft.WindowsPhone.Imaging
{
    internal interface IBlockStreamSource
    {
        long Length { get; }

        void ReadBlock(uint blockIndex, byte[] buffer, int bufferIndex);
    }
}