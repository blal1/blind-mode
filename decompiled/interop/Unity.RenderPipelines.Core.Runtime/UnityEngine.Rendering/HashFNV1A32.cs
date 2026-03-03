using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct HashFNV1A32
{
	private sealed class MethodInfoStoreGeneric_Append_Public_Void_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Append_Public_Void_T_0, Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_Prime;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_OffsetBasis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hash;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_HashFNV1A32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Void_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFuncHashCode_Internal_Static_Int32_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public uint m_Hash;

	public unsafe static uint k_Prime
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Prime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Prime, (void*)(&value));
		}
	}

	public unsafe static uint k_OffsetBasis
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_OffsetBasis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_OffsetBasis, (void*)(&value));
		}
	}

	public unsafe int value
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static HashFNV1A32()
	{
		Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HashFNV1A32");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr);
		NativeFieldInfoPtr_k_Prime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, "k_Prime");
		NativeFieldInfoPtr_k_OffsetBasis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, "k_OffsetBasis");
		NativeFieldInfoPtr_m_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, "m_Hash");
		NativeMethodInfoPtr_Create_Public_Static_HashFNV1A32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666738);
		NativeMethodInfoPtr_Append_Public_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666739);
		NativeMethodInfoPtr_Append_Public_Void_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666740);
		NativeMethodInfoPtr_Append_Public_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666741);
		NativeMethodInfoPtr_Append_Public_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666742);
		NativeMethodInfoPtr_Append_Public_Void_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666743);
		NativeMethodInfoPtr_Append_Public_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666744);
		NativeMethodInfoPtr_Append_Public_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666745);
		NativeMethodInfoPtr_Append_Public_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666746);
		NativeMethodInfoPtr_Append_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666747);
		NativeMethodInfoPtr_Append_Public_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666748);
		NativeMethodInfoPtr_GetFuncHashCode_Internal_Static_Int32_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666749);
		NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666750);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, 100666751);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1053119, RefRangeEnd = 1053122, XrefRangeStart = 1053119, XrefRangeEnd = 1053119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashFNV1A32 Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_HashFNV1A32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HashFNV1A32*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Append([In] ref int input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Append([In] ref uint input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Append([In] ref bool input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053122, XrefRangeEnd = 1053123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append([In] ref float input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Append([In] ref double input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053123, XrefRangeEnd = 1053125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append([In] ref Vector2 input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053125, XrefRangeEnd = 1053128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append([In] ref Vector3 input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053128, XrefRangeEnd = 1053132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append([In] ref Vector4 input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_byref_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053132, XrefRangeEnd = 1053137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append<T>(T input) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = input;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref input;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Append_Public_Void_T_0<T>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1053139, RefRangeEnd = 1053140, XrefRangeStart = 1053137, XrefRangeEnd = 1053139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Append(Il2CppSystem.Delegate del)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)del);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Public_Void_Delegate_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053140, XrefRangeEnd = 1053142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetFuncHashCode(Il2CppSystem.Delegate del)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)del);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFuncHashCode_Internal_Static_Int32_Delegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(175)]
	[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashFNV1A32>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
