using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ContactPairHeader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BodyID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherBodyID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StartPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NbPairs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_body_Public_get_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_otherBody_Public_get_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasRemovedBody_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContactPair_Public_byref_ContactPair_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContactPair_Internal_Internal_ptr_ContactPair_Int32_0;

	[FieldOffset(0)]
	public readonly int m_BodyID;

	[FieldOffset(4)]
	public readonly int m_OtherBodyID;

	[FieldOffset(8)]
	public readonly System.IntPtr m_StartPtr;

	[FieldOffset(16)]
	public readonly uint m_NbPairs;

	[FieldOffset(20)]
	public readonly CollisionPairHeaderFlags m_Flags;

	[FieldOffset(24)]
	public readonly Vector3 m_RelativeVelocity;

	public unsafe Component body
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259710, XrefRangeEnd = 1259714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_body_Public_get_Component_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}
	}

	public unsafe Component otherBody
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259714, XrefRangeEnd = 1259718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_otherBody_Public_get_Component_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}
	}

	public unsafe bool hasRemovedBody
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasRemovedBody_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int bodyInstanceID => m_BodyID;

	public int otherBodyInstanceID => m_OtherBodyID;

	public int pairCount => (int)m_NbPairs;

	public int BodyInstanceID => bodyInstanceID;

	public int OtherBodyInstanceID => otherBodyInstanceID;

	public Component Body => body;

	public Component OtherBody => otherBody;

	public int PairCount => pairCount;

	static ContactPairHeader()
	{
		Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPairHeader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr);
		NativeFieldInfoPtr_m_BodyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_BodyID");
		NativeFieldInfoPtr_m_OtherBodyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_OtherBodyID");
		NativeFieldInfoPtr_m_StartPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_StartPtr");
		NativeFieldInfoPtr_m_NbPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_NbPairs");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, "m_RelativeVelocity");
		NativeMethodInfoPtr_get_body_Public_get_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_get_otherBody_Public_get_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_get_hasRemovedBody_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_GetContactPair_Public_byref_ContactPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_GetContactPair_Internal_Internal_ptr_ContactPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, 100663400);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259718, XrefRangeEnd = 1259719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref ContactPair GetContactPair(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContactPair_Public_byref_ContactPair_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(ContactPair*)intPtr2;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259720, RefRangeEnd = 1259722, XrefRangeStart = 1259719, XrefRangeEnd = 1259720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContactPair* GetContactPair_Internal(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContactPair_Internal_Internal_ptr_ContactPair_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (ContactPair*)result;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPairHeader>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
