using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class HLSLArray : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_arraySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0;

	public unsafe int arraySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arraySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arraySize)) = value;
		}
	}

	public unsafe Il2CppSystem.Type elementType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static HLSLArray()
	{
		Il2CppClassPointerStore<HLSLArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HLSLArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr);
		NativeFieldInfoPtr_arraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr, "arraySize");
		NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr, "elementType");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr, 100666054);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1046931, XrefRangeEnd = 1046933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HLSLArray(int arraySize, Il2CppSystem.Type elementType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&arraySize);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elementType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HLSLArray(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
