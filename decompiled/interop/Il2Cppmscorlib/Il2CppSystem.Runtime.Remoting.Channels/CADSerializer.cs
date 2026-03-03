using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels;

public class CADSerializer : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0;

	static CADSerializer()
	{
		Il2CppClassPointerStore<CADSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CADSerializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr);
		NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670175);
		NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670176);
		NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670177);
		NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670178);
		NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100670179);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794573, RefRangeEnd = 794574, XrefRangeStart = 794568, XrefRangeEnd = 794573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794588, RefRangeEnd = 794591, XrefRangeStart = 794574, XrefRangeEnd = 794588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MemoryStream SerializeMessage(IMessage msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794606, RefRangeEnd = 794607, XrefRangeStart = 794591, XrefRangeEnd = 794606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object DeserializeObjectSafe(Il2CppStructArray<byte> mem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 794621, RefRangeEnd = 794626, XrefRangeStart = 794607, XrefRangeEnd = 794621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MemoryStream SerializeObject(Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794626, XrefRangeEnd = 794633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object DeserializeObject(MemoryStream mem)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public CADSerializer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
