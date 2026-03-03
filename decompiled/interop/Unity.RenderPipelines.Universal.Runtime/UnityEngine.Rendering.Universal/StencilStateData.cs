using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[System.Serializable]
public class StencilStateData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_overrideStencilState;

	private static readonly System.IntPtr NativeFieldInfoPtr_stencilReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_stencilCompareFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr_passOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_failOperation;

	private static readonly System.IntPtr NativeFieldInfoPtr_zFailOperation;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool overrideStencilState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideStencilState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideStencilState)) = value;
		}
	}

	public unsafe int stencilReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilReference);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilReference)) = value;
		}
	}

	public unsafe CompareFunction stencilCompareFunction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilCompareFunction);
			return *(CompareFunction*)num;
		}
		set
		{
			*(CompareFunction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilCompareFunction)) = value;
		}
	}

	public unsafe StencilOp passOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passOperation);
			return *(StencilOp*)num;
		}
		set
		{
			*(StencilOp*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passOperation)) = value;
		}
	}

	public unsafe StencilOp failOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_failOperation);
			return *(StencilOp*)num;
		}
		set
		{
			*(StencilOp*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_failOperation)) = value;
		}
	}

	public unsafe StencilOp zFailOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zFailOperation);
			return *(StencilOp*)num;
		}
		set
		{
			*(StencilOp*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zFailOperation)) = value;
		}
	}

	static StencilStateData()
	{
		Il2CppClassPointerStore<StencilStateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "StencilStateData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr);
		NativeFieldInfoPtr_overrideStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "overrideStencilState");
		NativeFieldInfoPtr_stencilReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "stencilReference");
		NativeFieldInfoPtr_stencilCompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "stencilCompareFunction");
		NativeFieldInfoPtr_passOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "passOperation");
		NativeFieldInfoPtr_failOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "failOperation");
		NativeFieldInfoPtr_zFailOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, "zFailOperation");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr, 100663328);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1076312, RefRangeEnd = 1076315, XrefRangeStart = 1076103, XrefRangeEnd = 1076312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StencilStateData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StencilStateData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public StencilStateData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
