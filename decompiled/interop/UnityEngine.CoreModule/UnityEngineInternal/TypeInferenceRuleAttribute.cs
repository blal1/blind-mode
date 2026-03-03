using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngineInternal;

[System.Serializable]
public class TypeInferenceRuleAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__rule;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe string _rule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rule);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rule)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static TypeInferenceRuleAttribute()
	{
		Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "TypeInferenceRuleAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, "_rule");
		NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663303);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163734, XrefRangeEnd = 1163739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypeInferenceRuleAttribute(TypeInferenceRules rule)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rule);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypeInferenceRuleAttribute(string rule)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rule);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(200)]
	[CachedScanResults(RefRangeStart = 1156232, RefRangeEnd = 1156432, XrefRangeStart = 1156232, XrefRangeEnd = 1156432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public TypeInferenceRuleAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
