using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct AssemblyVersion
{
	private static readonly System.IntPtr NativeFieldInfoPtr_major;

	private static readonly System.IntPtr NativeFieldInfoPtr_minor;

	private static readonly System.IntPtr NativeFieldInfoPtr_build;

	private static readonly System.IntPtr NativeFieldInfoPtr_revision;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public ushort major;

	[FieldOffset(2)]
	public ushort minor;

	[FieldOffset(4)]
	public ushort build;

	[FieldOffset(6)]
	public ushort revision;

	static AssemblyVersion()
	{
		Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AssemblyVersion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr);
		NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "major");
		NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "minor");
		NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "build");
		NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "revision");
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666233);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666234);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666235);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100666236);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(AssemblyVersion lhs, AssemblyVersion rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(AssemblyVersion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187315, XrefRangeEnd = 1187337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187337, XrefRangeEnd = 1187340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1187346, RefRangeEnd = 1187347, XrefRangeStart = 1187340, XrefRangeEnd = 1187346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(AssemblyVersion lhs, AssemblyVersion rhs)
	{
		return !(lhs == rhs);
	}

	public static bool operator <(AssemblyVersion lhs, AssemblyVersion rhs)
	{
		if (lhs.major != rhs.major)
		{
			return lhs.major < rhs.major;
		}
		if (lhs.minor != rhs.minor)
		{
			return lhs.minor < rhs.minor;
		}
		if (lhs.build != rhs.build)
		{
			return lhs.build < rhs.build;
		}
		if (lhs.revision != rhs.revision)
		{
			return lhs.revision < rhs.revision;
		}
		return false;
	}

	public static bool operator >(AssemblyVersion lhs, AssemblyVersion rhs)
	{
		if (lhs.major != rhs.major)
		{
			return lhs.major > rhs.major;
		}
		if (lhs.minor != rhs.minor)
		{
			return lhs.minor > rhs.minor;
		}
		if (lhs.build != rhs.build)
		{
			return lhs.build > rhs.build;
		}
		if (lhs.revision != rhs.revision)
		{
			return lhs.revision > rhs.revision;
		}
		return false;
	}
}
