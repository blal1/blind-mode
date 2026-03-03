using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public sealed class WaitForSeconds : YieldInstruction
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Seconds;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	public unsafe float m_Seconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Seconds);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Seconds)) = value;
		}
	}

	static WaitForSeconds()
	{
		Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSeconds");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr);
		NativeFieldInfoPtr_m_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, "m_Seconds");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, 100666582);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 1215111, RefRangeEnd = 1215158, XrefRangeStart = 1215110, XrefRangeEnd = 1215111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitForSeconds(float seconds)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&seconds);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public WaitForSeconds(IntPtr pointer)
		: base(pointer)
	{
	}
}
