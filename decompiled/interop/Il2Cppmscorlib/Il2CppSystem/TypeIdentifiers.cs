using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public class TypeIdentifiers : Object
{
	public class Display : TypeNames.ATypeName
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_displayName;

		private static readonly System.IntPtr NativeFieldInfoPtr_internal_name;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInternalName_Private_String_0;

		public unsafe string displayName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string internal_name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internal_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internal_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe override string DisplayName
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		public unsafe virtual string InternalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765306, XrefRangeEnd = 765315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		static Display()
		{
			Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, "Display");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
			NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "displayName");
			NativeFieldInfoPtr_internal_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "internal_name");
			NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100667343);
			NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100667344);
			NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100667345);
			NativeMethodInfoPtr_GetInternalName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100667346);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765304, XrefRangeEnd = 765306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Display(string displayName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765315, XrefRangeEnd = 765324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInternalName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInternalName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public Display(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0;

	static TypeIdentifiers()
	{
		Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifiers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr);
		NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, 100667342);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 765329, RefRangeEnd = 765332, XrefRangeStart = 765324, XrefRangeEnd = 765329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TypeIdentifier FromDisplay(string displayName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr2) : null;
	}

	public TypeIdentifiers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
