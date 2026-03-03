using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.VFX;

public class VFXExpressionValues : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXExpressionValues_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXExpressionValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663353);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(VFXExpressionValues vFXExpressionValues)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vFXExpressionValues);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXExpressionValues_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate void GetVector2_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate void GetVector4_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate void GetMatrix4x4_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetTexture_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate System.IntPtr GetMesh_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate void Internal_GetAnimationCurveFromScript_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr curve);

	private delegate void Internal_GetGradientFromScript_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr gradient);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateExpressionValuesWrapper_Internal_Static_VFXExpressionValues_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUInt_Public_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Public_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Injected_Private_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUInt_Injected_Private_Static_UInt32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Injected_Private_Static_Single_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVector3_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0;

	private static readonly GetVector2_InjectedDelegate GetVector2_InjectedDelegateField;

	private static readonly GetVector4_InjectedDelegate GetVector4_InjectedDelegateField;

	private static readonly GetMatrix4x4_InjectedDelegate GetMatrix4x4_InjectedDelegateField;

	private static readonly GetTexture_InjectedDelegate GetTexture_InjectedDelegateField;

	private static readonly GetMesh_InjectedDelegate GetMesh_InjectedDelegateField;

	private static readonly Internal_GetAnimationCurveFromScript_InjectedDelegate Internal_GetAnimationCurveFromScript_InjectedDelegateField;

	private static readonly Internal_GetGradientFromScript_InjectedDelegate Internal_GetGradientFromScript_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	static VFXExpressionValues()
	{
		Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXExpressionValues");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_CreateExpressionValuesWrapper_Internal_Static_VFXExpressionValues_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_GetBool_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_GetInt_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_GetUInt_Public_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_GetVector3_Public_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_GetBool_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_GetInt_Injected_Private_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_GetUInt_Injected_Private_Static_UInt32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_GetFloat_Injected_Private_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_GetVector3_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663352);
		GetVector2_InjectedDelegateField = IL2CPP.ResolveICall<GetVector2_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetVector2_Injected");
		GetVector4_InjectedDelegateField = IL2CPP.ResolveICall<GetVector4_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetVector4_Injected");
		GetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetMatrix4x4_Injected");
		GetTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetTexture_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetTexture_Injected");
		GetMesh_InjectedDelegateField = IL2CPP.ResolveICall<GetMesh_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetMesh_Injected");
		Internal_GetAnimationCurveFromScript_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetAnimationCurveFromScript_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::Internal_GetAnimationCurveFromScript_Injected");
		Internal_GetGradientFromScript_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetGradientFromScript_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::Internal_GetGradientFromScript_Injected");
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXExpressionValues()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408979, XrefRangeEnd = 1408983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXExpressionValues CreateExpressionValuesWrapper(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateExpressionValuesWrapper_Internal_Static_VFXExpressionValues_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXExpressionValues>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408987, RefRangeEnd = 1408988, XrefRangeStart = 1408983, XrefRangeEnd = 1408987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBool(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408992, RefRangeEnd = 1408993, XrefRangeStart = 1408988, XrefRangeEnd = 1408992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408997, RefRangeEnd = 1408998, XrefRangeStart = 1408993, XrefRangeEnd = 1408997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetUInt(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUInt_Public_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1409002, RefRangeEnd = 1409006, XrefRangeStart = 1408998, XrefRangeEnd = 1409002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1409009, RefRangeEnd = 1409011, XrefRangeStart = 1409006, XrefRangeEnd = 1409009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetVector3(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Public_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409011, XrefRangeEnd = 1409013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetBool_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409013, XrefRangeEnd = 1409015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetInt_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Injected_Private_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409015, XrefRangeEnd = 1409017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetUInt_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUInt_Injected_Private_Static_UInt32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409017, XrefRangeEnd = 1409019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetFloat_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Injected_Private_Static_Single_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409019, XrefRangeEnd = 1409021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVector3_Injected(System.IntPtr _unity_self, int nameID, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVector3_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VFXExpressionValues(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Vector2 GetVector2(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVector2_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public Vector4 GetVector4(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVector4_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public Matrix4x4 GetMatrix4x4(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetMatrix4x4_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public Texture GetTexture(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Texture>(GetTexture_Injected(intPtr, nameID));
	}

	public Mesh GetMesh(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Mesh>(GetMesh_Injected(intPtr, nameID));
	}

	public AnimationCurve GetAnimationCurve(int nameID)
	{
		AnimationCurve animationCurve = new AnimationCurve();
		Internal_GetAnimationCurveFromScript(nameID, animationCurve);
		return animationCurve;
	}

	public void Internal_GetAnimationCurveFromScript(int nameID, AnimationCurve curve)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_GetAnimationCurveFromScript_Injected(intPtr, nameID, (curve == null) ? ((System.IntPtr)0) : AnimationCurve.BindingsMarshaller.ConvertToNative(curve));
	}

	public Gradient GetGradient(int nameID)
	{
		Gradient gradient = new Gradient();
		Internal_GetGradientFromScript(nameID, gradient);
		return gradient;
	}

	public void Internal_GetGradientFromScript(int nameID, Gradient gradient)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_GetGradientFromScript_Injected(intPtr, nameID, (gradient == null) ? ((System.IntPtr)0) : Gradient.BindingsMarshaller.ConvertToNative(gradient));
	}

	public bool GetBool(string name)
	{
		return GetBool(Shader.PropertyToID(name));
	}

	public int GetInt(string name)
	{
		return GetInt(Shader.PropertyToID(name));
	}

	public uint GetUInt(string name)
	{
		return GetUInt(Shader.PropertyToID(name));
	}

	public float GetFloat(string name)
	{
		return GetFloat(Shader.PropertyToID(name));
	}

	public Vector2 GetVector2(string name)
	{
		return GetVector2(Shader.PropertyToID(name));
	}

	public Vector3 GetVector3(string name)
	{
		return GetVector3(Shader.PropertyToID(name));
	}

	public Vector4 GetVector4(string name)
	{
		return GetVector4(Shader.PropertyToID(name));
	}

	public Matrix4x4 GetMatrix4x4(string name)
	{
		return GetMatrix4x4(Shader.PropertyToID(name));
	}

	public Texture GetTexture(string name)
	{
		return GetTexture(Shader.PropertyToID(name));
	}

	public AnimationCurve GetAnimationCurve(string name)
	{
		return GetAnimationCurve(Shader.PropertyToID(name));
	}

	public Gradient GetGradient(string name)
	{
		return GetGradient(Shader.PropertyToID(name));
	}

	public Mesh GetMesh(string name)
	{
		return GetMesh(Shader.PropertyToID(name));
	}

	public unsafe static void GetVector2_Injected(System.IntPtr _unity_self, int nameID, out Vector2 ret)
	{
		GetVector2_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetVector4_Injected(System.IntPtr _unity_self, int nameID, out Vector4 ret)
	{
		GetVector4_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMatrix4x4_Injected(System.IntPtr _unity_self, int nameID, out Matrix4x4 ret)
	{
		GetMatrix4x4_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public static System.IntPtr GetTexture_Injected(System.IntPtr _unity_self, int nameID)
	{
		return GetTexture_InjectedDelegateField(_unity_self, nameID);
	}

	public static System.IntPtr GetMesh_Injected(System.IntPtr _unity_self, int nameID)
	{
		return GetMesh_InjectedDelegateField(_unity_self, nameID);
	}

	public static void Internal_GetAnimationCurveFromScript_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr curve)
	{
		Internal_GetAnimationCurveFromScript_InjectedDelegateField(_unity_self, nameID, curve);
	}

	public static void Internal_GetGradientFromScript_Injected(System.IntPtr _unity_self, int nameID, System.IntPtr gradient)
	{
		Internal_GetGradientFromScript_InjectedDelegateField(_unity_self, nameID, gradient);
	}
}
