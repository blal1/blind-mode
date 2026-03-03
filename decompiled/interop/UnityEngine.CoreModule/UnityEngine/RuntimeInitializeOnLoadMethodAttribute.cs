using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Scripting;

namespace UnityEngine;

public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_m_LoadType;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0;

	public unsafe RuntimeInitializeLoadType m_LoadType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadType);
			return *(RuntimeInitializeLoadType*)num;
		}
		set
		{
			*(RuntimeInitializeLoadType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LoadType)) = value;
		}
	}

	public unsafe RuntimeInitializeLoadType loadType
	{
		get
		{
			return m_LoadType;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RuntimeInitializeOnLoadMethodAttribute()
	{
		Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RuntimeInitializeOnLoadMethodAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_LoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, "m_LoadType");
		NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100666458);
		NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100666459);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&loadType);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RuntimeInitializeOnLoadMethodAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
