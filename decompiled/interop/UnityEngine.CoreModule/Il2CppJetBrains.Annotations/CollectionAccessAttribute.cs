using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations;

public sealed class CollectionAccessAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__CollectionAccessType_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0;

	public unsafe CollectionAccessType _CollectionAccessType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CollectionAccessType_k__BackingField);
			return *(CollectionAccessType*)num;
		}
		set
		{
			*(CollectionAccessType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CollectionAccessType_k__BackingField)) = value;
		}
	}

	public CollectionAccessType CollectionAccessType => _CollectionAccessType_k__BackingField;

	static CollectionAccessAttribute()
	{
		Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "CollectionAccessAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__CollectionAccessType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr, "<CollectionAccessType>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr, 100663682);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CollectionAccessAttribute(CollectionAccessType collectionAccessType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&collectionAccessType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CollectionAccessAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
