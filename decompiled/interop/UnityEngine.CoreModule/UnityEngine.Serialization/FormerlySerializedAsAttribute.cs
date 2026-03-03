using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Serialization;

public class FormerlySerializedAsAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_oldName;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string m_oldName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_oldName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_oldName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public string oldName => m_oldName;

	static FormerlySerializedAsAttribute()
	{
		Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Serialization", "FormerlySerializedAsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, "m_oldName");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100667226);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FormerlySerializedAsAttribute(string oldName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FormerlySerializedAsAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
