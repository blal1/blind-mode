using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public sealed class AssetFileNameExtensionAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__preferredExtension_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__otherExtensions_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;

	public unsafe string _preferredExtension_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preferredExtension_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__preferredExtension_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe IEnumerable<string> _otherExtensions_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__otherExtensions_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__otherExtensions_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public string preferredExtension => _preferredExtension_k__BackingField;

	public IEnumerable<string> otherExtensions => _otherExtensions_k__BackingField;

	static AssetFileNameExtensionAttribute()
	{
		Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "AssetFileNameExtensionAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__preferredExtension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr, "<preferredExtension>k__BackingField");
		NativeFieldInfoPtr__otherExtensions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr, "<otherExtensions>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr, 100663297);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetFileNameExtensionAttribute(string preferredExtension, [Optional] Il2CppStringArray otherExtensions)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		if (otherExtensions == null)
		{
			otherExtensions = new Il2CppStringArray(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetFileNameExtensionAttribute>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(preferredExtension);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherExtensions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AssetFileNameExtensionAttribute(string preferredExtension, params string[] otherExtensions)
		: this(preferredExtension, new Il2CppStringArray(otherExtensions))
	{
	}//IL_0003: Unknown result type (might be due to invalid IL or missing references)
	//IL_000d: Expected O, but got Unknown


	public AssetFileNameExtensionAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
