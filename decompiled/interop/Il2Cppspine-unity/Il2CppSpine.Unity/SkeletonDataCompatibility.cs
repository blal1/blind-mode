using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine.Unity;

public static class SkeletonDataCompatibility : Il2CppSystem.Object
{
	[OriginalName("spine-unity.dll", "", "SourceType")]
	public enum SourceType
	{
		Json,
		Binary
	}

	[System.Serializable]
	public class VersionInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rawVersion;

		private static readonly System.IntPtr NativeFieldInfoPtr_version;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string rawVersion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawVersion);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rawVersion)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Il2CppStructArray<int> version
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SourceType sourceType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceType);
				return *(SourceType*)num;
			}
			set
			{
				*(SourceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceType)) = value;
			}
		}

		static VersionInfo()
		{
			Il2CppClassPointerStore<VersionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkeletonDataCompatibility>.NativeClassPtr, "VersionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr);
			NativeFieldInfoPtr_rawVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "rawVersion");
			NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "version");
			NativeFieldInfoPtr_sourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, "sourceType");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr, 100663412);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public VersionInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CompatibilityProblemInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_actualVersion;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleVersions;

		private static readonly System.IntPtr NativeFieldInfoPtr_explicitProblemDescription;

		private static readonly System.IntPtr NativeMethodInfoPtr_DescriptionString_Public_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe VersionInfo actualVersion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualVersion);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VersionInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualVersion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> compatibleVersions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleVersions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleVersions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string explicitProblemDescription
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explicitProblemDescription);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_explicitProblemDescription)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static CompatibilityProblemInfo()
		{
			Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkeletonDataCompatibility>.NativeClassPtr, "CompatibilityProblemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr);
			NativeFieldInfoPtr_actualVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr, "actualVersion");
			NativeFieldInfoPtr_compatibleVersions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr, "compatibleVersions");
			NativeFieldInfoPtr_explicitProblemDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr, "explicitProblemDescription");
			NativeMethodInfoPtr_DescriptionString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr, 100663413);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr, 100663414);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851014, XrefRangeEnd = 851046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DescriptionString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DescriptionString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompatibilityProblemInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompatibilityProblemInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CompatibilityProblemInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	static SkeletonDataCompatibility()
	{
		Il2CppClassPointerStore<SkeletonDataCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SkeletonDataCompatibility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkeletonDataCompatibility>.NativeClassPtr);
	}

	public SkeletonDataCompatibility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
