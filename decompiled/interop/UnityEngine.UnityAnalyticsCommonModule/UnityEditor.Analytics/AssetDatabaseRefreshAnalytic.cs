using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Analytics;

namespace UnityEditor.Analytics;

[Serializable]
public class AssetDatabaseRefreshAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_isV2;

	private static readonly IntPtr NativeFieldInfoPtr_Imports_Imported;

	private static readonly IntPtr NativeFieldInfoPtr_Imports_ImportedInProcess;

	private static readonly IntPtr NativeFieldInfoPtr_Imports_ImportedOutOfProcess;

	private static readonly IntPtr NativeFieldInfoPtr_Imports_Refresh;

	private static readonly IntPtr NativeFieldInfoPtr_Imports_DomainReload;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_MetadataRequested;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_MetadataDownloaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_MetadataFailedToDownload;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_MetadataUploaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactsFailedToUpload;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_MetadataVersionsDownloaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_MetadataMatched;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactsDownloaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactFilesDownloaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToDownload;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactsUploaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactFilesUploaded;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToUpload;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_Connects;

	private static readonly IntPtr NativeFieldInfoPtr_CacheServer_Disconnects;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateAssetDatabaseRefreshAnalytic_Internal_Static_AssetDatabaseRefreshAnalytic_0;

	public unsafe bool isV2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isV2);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isV2)) = value;
		}
	}

	public unsafe long Imports_Imported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_Imported);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_Imported)) = value;
		}
	}

	public unsafe long Imports_ImportedInProcess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_ImportedInProcess);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_ImportedInProcess)) = value;
		}
	}

	public unsafe long Imports_ImportedOutOfProcess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_ImportedOutOfProcess);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_ImportedOutOfProcess)) = value;
		}
	}

	public unsafe long Imports_Refresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_Refresh);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_Refresh)) = value;
		}
	}

	public unsafe long Imports_DomainReload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_DomainReload);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Imports_DomainReload)) = value;
		}
	}

	public unsafe long CacheServer_MetadataRequested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataRequested);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataRequested)) = value;
		}
	}

	public unsafe long CacheServer_MetadataDownloaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataDownloaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataDownloaded)) = value;
		}
	}

	public unsafe long CacheServer_MetadataFailedToDownload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataFailedToDownload);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataFailedToDownload)) = value;
		}
	}

	public unsafe long CacheServer_MetadataUploaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataUploaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataUploaded)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactsFailedToUpload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactsFailedToUpload);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactsFailedToUpload)) = value;
		}
	}

	public unsafe long CacheServer_MetadataVersionsDownloaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataVersionsDownloaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataVersionsDownloaded)) = value;
		}
	}

	public unsafe long CacheServer_MetadataMatched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataMatched);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_MetadataMatched)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactsDownloaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactsDownloaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactsDownloaded)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactFilesDownloaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesDownloaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesDownloaded)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactFilesFailedToDownload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToDownload);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToDownload)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactsUploaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactsUploaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactsUploaded)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactFilesUploaded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesUploaded);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesUploaded)) = value;
		}
	}

	public unsafe long CacheServer_ArtifactFilesFailedToUpload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToUpload);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToUpload)) = value;
		}
	}

	public unsafe long CacheServer_Connects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_Connects);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_Connects)) = value;
		}
	}

	public unsafe long CacheServer_Disconnects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_Disconnects);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheServer_Disconnects)) = value;
		}
	}

	static AssetDatabaseRefreshAnalytic()
	{
		Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsCommonModule.dll", "UnityEditor.Analytics", "AssetDatabaseRefreshAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_isV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "isV2");
		NativeFieldInfoPtr_Imports_Imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "Imports_Imported");
		NativeFieldInfoPtr_Imports_ImportedInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "Imports_ImportedInProcess");
		NativeFieldInfoPtr_Imports_ImportedOutOfProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "Imports_ImportedOutOfProcess");
		NativeFieldInfoPtr_Imports_Refresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "Imports_Refresh");
		NativeFieldInfoPtr_Imports_DomainReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "Imports_DomainReload");
		NativeFieldInfoPtr_CacheServer_MetadataRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_MetadataRequested");
		NativeFieldInfoPtr_CacheServer_MetadataDownloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_MetadataDownloaded");
		NativeFieldInfoPtr_CacheServer_MetadataFailedToDownload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_MetadataFailedToDownload");
		NativeFieldInfoPtr_CacheServer_MetadataUploaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_MetadataUploaded");
		NativeFieldInfoPtr_CacheServer_ArtifactsFailedToUpload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactsFailedToUpload");
		NativeFieldInfoPtr_CacheServer_MetadataVersionsDownloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_MetadataVersionsDownloaded");
		NativeFieldInfoPtr_CacheServer_MetadataMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_MetadataMatched");
		NativeFieldInfoPtr_CacheServer_ArtifactsDownloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactsDownloaded");
		NativeFieldInfoPtr_CacheServer_ArtifactFilesDownloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactFilesDownloaded");
		NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToDownload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactFilesFailedToDownload");
		NativeFieldInfoPtr_CacheServer_ArtifactsUploaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactsUploaded");
		NativeFieldInfoPtr_CacheServer_ArtifactFilesUploaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactFilesUploaded");
		NativeFieldInfoPtr_CacheServer_ArtifactFilesFailedToUpload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_ArtifactFilesFailedToUpload");
		NativeFieldInfoPtr_CacheServer_Connects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_Connects");
		NativeFieldInfoPtr_CacheServer_Disconnects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, "CacheServer_Disconnects");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_CreateAssetDatabaseRefreshAnalytic_Internal_Static_AssetDatabaseRefreshAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr, 100663314);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407663, XrefRangeEnd = 1407668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetDatabaseRefreshAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetDatabaseRefreshAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407668, XrefRangeEnd = 1407676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAssetDatabaseRefreshAnalytic_Internal_Static_AssetDatabaseRefreshAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AssetDatabaseRefreshAnalytic>(intPtr2) : null;
	}

	public AssetDatabaseRefreshAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
