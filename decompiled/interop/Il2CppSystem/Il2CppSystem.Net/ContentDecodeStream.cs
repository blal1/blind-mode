using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net;

public class ContentDecodeStream : WebReadStream
{
	[OriginalName("System.dll", "", "Mode")]
	public enum Mode
	{
		GZip,
		Deflate
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__OriginalInnerStream_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ContentDecodeStream_WebOperation_Stream_Mode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalInnerStream_Private_get_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_WebOperation_Stream_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0;

	public unsafe Stream _OriginalInnerStream_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OriginalInnerStream_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OriginalInnerStream_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Stream OriginalInnerStream
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OriginalInnerStream_Private_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
		}
	}

	static ContentDecodeStream()
	{
		Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ContentDecodeStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr);
		NativeFieldInfoPtr__OriginalInnerStream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, "<OriginalInnerStream>k__BackingField");
		NativeMethodInfoPtr_Create_Public_Static_ContentDecodeStream_WebOperation_Stream_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100666575);
		NativeMethodInfoPtr_get_OriginalInnerStream_Private_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100666576);
		NativeMethodInfoPtr__ctor_Private_Void_WebOperation_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100666577);
		NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100666578);
		NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr, 100666579);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 891589, RefRangeEnd = 891590, XrefRangeStart = 891575, XrefRangeEnd = 891589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ContentDecodeStream Create(WebOperation operation, Stream innerStream, Mode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)operation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerStream);
		*(Mode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_ContentDecodeStream_WebOperation_Stream_Mode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContentDecodeStream>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 891553, RefRangeEnd = 891557, XrefRangeStart = 891553, XrefRangeEnd = 891557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentDecodeStream>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)operation);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decodeStream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)originalInnerStream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_WebOperation_Stream_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Task<int> ProcessReadAsync(Il2CppStructArray<byte> buffer, int offset, int size, CancellationToken cancellationToken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ProcessReadAsync_Protected_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 891590, XrefRangeEnd = 891599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Task FinishReading(CancellationToken cancellationToken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cancellationToken));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishReading_Internal_Virtual_Task_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
	}

	public ContentDecodeStream(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
