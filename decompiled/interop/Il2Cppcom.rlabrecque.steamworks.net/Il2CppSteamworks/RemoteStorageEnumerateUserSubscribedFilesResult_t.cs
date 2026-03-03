using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks;

public sealed class RemoteStorageEnumerateUserSubscribedFilesResult_t : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_eResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_nResultsReturned;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rgRTimeSubscribed;

	public unsafe EResult m_eResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_eResult);
			return *(EResult*)num;
		}
		set
		{
			*(EResult*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_eResult)) = value;
		}
	}

	public unsafe int m_nResultsReturned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nResultsReturned);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nResultsReturned)) = value;
		}
	}

	public unsafe int m_nTotalResultCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nTotalResultCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_nTotalResultCount)) = value;
		}
	}

	public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rgPublishedFileId);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rgPublishedFileId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<uint> m_rgRTimeSubscribed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rgRTimeSubscribed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rgRTimeSubscribed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RemoteStorageEnumerateUserSubscribedFilesResult_t()
	{
		Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("com.rlabrecque.steamworks.net.dll", "Steamworks", "RemoteStorageEnumerateUserSubscribedFilesResult_t");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr);
		NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_eResult");
		NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
		NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
		NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
		NativeFieldInfoPtr_m_rgRTimeSubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_rgRTimeSubscribed");
	}

	public RemoteStorageEnumerateUserSubscribedFilesResult_t(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RemoteStorageEnumerateUserSubscribedFilesResult_t()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr))
	{
	}
}
