using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices;

[System.Serializable]
[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "CallingConvention")]
public enum CallingConvention
{
	Winapi = 1,
	Cdecl,
	StdCall,
	ThisCall,
	FastCall
}
