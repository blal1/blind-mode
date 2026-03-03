using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct GenericBinding
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Path;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PropertyName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScriptInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TypeID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isObjectReference_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDiscrete_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSerializeReference_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_transformPathHash_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_propertyNameHash_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scriptInstanceID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeID_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_customTypeID_Public_get_Byte_0;

	[FieldOffset(0)]
	public readonly uint m_Path;

	[FieldOffset(4)]
	public readonly uint m_PropertyName;

	[FieldOffset(8)]
	public readonly int m_ScriptInstanceID;

	[FieldOffset(12)]
	public readonly int m_TypeID;

	[FieldOffset(16)]
	public readonly byte m_CustomType;

	[FieldOffset(20)]
	public readonly Flags m_Flags;

	public unsafe bool isObjectReference
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isObjectReference_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isDiscrete
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDiscrete_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isSerializeReference
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSerializeReference_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint transformPathHash
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transformPathHash_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint propertyNameHash
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_propertyNameHash_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int scriptInstanceID
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scriptInstanceID_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int typeID
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeID_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe byte customTypeID
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_customTypeID_Public_get_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GenericBinding()
	{
		Il2CppClassPointerStore<GenericBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "GenericBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr);
		NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, "m_Path");
		NativeFieldInfoPtr_m_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, "m_PropertyName");
		NativeFieldInfoPtr_m_ScriptInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, "m_ScriptInstanceID");
		NativeFieldInfoPtr_m_TypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, "m_TypeID");
		NativeFieldInfoPtr_m_CustomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, "m_CustomType");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, "m_Flags");
		NativeMethodInfoPtr_get_isObjectReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665151);
		NativeMethodInfoPtr_get_isDiscrete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665152);
		NativeMethodInfoPtr_get_isSerializeReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665153);
		NativeMethodInfoPtr_get_transformPathHash_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665154);
		NativeMethodInfoPtr_get_propertyNameHash_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665155);
		NativeMethodInfoPtr_get_scriptInstanceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665156);
		NativeMethodInfoPtr_get_typeID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665157);
		NativeMethodInfoPtr_get_customTypeID_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, 100665158);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenericBinding>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
