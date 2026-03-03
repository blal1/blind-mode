using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public sealed class XdrBuilder : SchemaBuilder
{
	public sealed class DeclBaseInfo : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Name;

		private static readonly System.IntPtr NativeFieldInfoPtr__Prefix;

		private static readonly System.IntPtr NativeFieldInfoPtr__TypeName;

		private static readonly System.IntPtr NativeFieldInfoPtr__TypePrefix;

		private static readonly System.IntPtr NativeFieldInfoPtr__Default;

		private static readonly System.IntPtr NativeFieldInfoPtr__Revises;

		private static readonly System.IntPtr NativeFieldInfoPtr__MaxOccurs;

		private static readonly System.IntPtr NativeFieldInfoPtr__MinOccurs;

		private static readonly System.IntPtr NativeFieldInfoPtr__Checking;

		private static readonly System.IntPtr NativeFieldInfoPtr__ElementDecl;

		private static readonly System.IntPtr NativeFieldInfoPtr__Attdef;

		private static readonly System.IntPtr NativeFieldInfoPtr__Next;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		public unsafe XmlQualifiedName _Name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string _Prefix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Prefix);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Prefix)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe XmlQualifiedName _TypeName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TypeName);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TypeName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string _TypePrefix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TypePrefix);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TypePrefix)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Object _Default
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Default);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Default)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Object _Revises
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Revises);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Revises)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe uint _MaxOccurs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxOccurs);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxOccurs)) = value;
			}
		}

		public unsafe uint _MinOccurs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinOccurs);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinOccurs)) = value;
			}
		}

		public unsafe bool _Checking
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Checking);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Checking)) = value;
			}
		}

		public unsafe SchemaElementDecl _ElementDecl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElementDecl);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElementDecl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SchemaAttDef _Attdef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attdef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attdef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DeclBaseInfo _Next
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Next);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeclBaseInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Next)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DeclBaseInfo()
		{
			Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "DeclBaseInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr);
			NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Name");
			NativeFieldInfoPtr__Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Prefix");
			NativeFieldInfoPtr__TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_TypeName");
			NativeFieldInfoPtr__TypePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_TypePrefix");
			NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Default");
			NativeFieldInfoPtr__Revises = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Revises");
			NativeFieldInfoPtr__MaxOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_MaxOccurs");
			NativeFieldInfoPtr__MinOccurs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_MinOccurs");
			NativeFieldInfoPtr__Checking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Checking");
			NativeFieldInfoPtr__ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_ElementDecl");
			NativeFieldInfoPtr__Attdef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Attdef");
			NativeFieldInfoPtr__Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, "_Next");
			NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, 100667213);
			NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr, 100667214);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935948, XrefRangeEnd = 935950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeclBaseInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeclBaseInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 935964, RefRangeEnd = 935968, XrefRangeStart = 935950, XrefRangeEnd = 935964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DeclBaseInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class GroupContent : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__MinVal;

		private static readonly System.IntPtr NativeFieldInfoPtr__MaxVal;

		private static readonly System.IntPtr NativeFieldInfoPtr__HasMaxAttr;

		private static readonly System.IntPtr NativeFieldInfoPtr__HasMinAttr;

		private static readonly System.IntPtr NativeFieldInfoPtr__Order;

		private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe uint _MinVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinVal);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinVal)) = value;
			}
		}

		public unsafe uint _MaxVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxVal);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxVal)) = value;
			}
		}

		public unsafe bool _HasMaxAttr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasMaxAttr);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasMaxAttr)) = value;
			}
		}

		public unsafe bool _HasMinAttr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasMinAttr);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasMinAttr)) = value;
			}
		}

		public unsafe int _Order
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Order);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Order)) = value;
			}
		}

		static GroupContent()
		{
			Il2CppClassPointerStore<GroupContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "GroupContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupContent>.NativeClassPtr);
			NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, "_MinVal");
			NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, "_MaxVal");
			NativeFieldInfoPtr__HasMaxAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, "_HasMaxAttr");
			NativeFieldInfoPtr__HasMinAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, "_HasMinAttr");
			NativeFieldInfoPtr__Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, "_Order");
			NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, 100667215);
			NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, 100667216);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupContent>.NativeClassPtr, 100667217);
		}

		[CallerCount(0)]
		public unsafe static void Copy(GroupContent from, GroupContent to)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Internal_Static_Void_GroupContent_GroupContent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935968, XrefRangeEnd = 935972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GroupContent Copy(GroupContent other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Internal_Static_GroupContent_GroupContent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GroupContent>(intPtr2) : null;
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupContent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public GroupContent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class ElementContent : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__ElementDecl;

		private static readonly System.IntPtr NativeFieldInfoPtr__ContentAttr;

		private static readonly System.IntPtr NativeFieldInfoPtr__OrderAttr;

		private static readonly System.IntPtr NativeFieldInfoPtr__MasterGroupRequired;

		private static readonly System.IntPtr NativeFieldInfoPtr__ExistTerminal;

		private static readonly System.IntPtr NativeFieldInfoPtr__AllowDataType;

		private static readonly System.IntPtr NativeFieldInfoPtr__HasDataType;

		private static readonly System.IntPtr NativeFieldInfoPtr__HasType;

		private static readonly System.IntPtr NativeFieldInfoPtr__EnumerationRequired;

		private static readonly System.IntPtr NativeFieldInfoPtr__MinVal;

		private static readonly System.IntPtr NativeFieldInfoPtr__MaxVal;

		private static readonly System.IntPtr NativeFieldInfoPtr__MaxLength;

		private static readonly System.IntPtr NativeFieldInfoPtr__MinLength;

		private static readonly System.IntPtr NativeFieldInfoPtr__AttDefList;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SchemaElementDecl _ElementDecl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElementDecl);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElementDecl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _ContentAttr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ContentAttr);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ContentAttr)) = value;
			}
		}

		public unsafe int _OrderAttr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OrderAttr);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OrderAttr)) = value;
			}
		}

		public unsafe bool _MasterGroupRequired
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MasterGroupRequired);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MasterGroupRequired)) = value;
			}
		}

		public unsafe bool _ExistTerminal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ExistTerminal);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ExistTerminal)) = value;
			}
		}

		public unsafe bool _AllowDataType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AllowDataType);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AllowDataType)) = value;
			}
		}

		public unsafe bool _HasDataType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasDataType);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasDataType)) = value;
			}
		}

		public unsafe bool _HasType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasType);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasType)) = value;
			}
		}

		public unsafe bool _EnumerationRequired
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnumerationRequired);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnumerationRequired)) = value;
			}
		}

		public unsafe uint _MinVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinVal);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinVal)) = value;
			}
		}

		public unsafe uint _MaxVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxVal);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxVal)) = value;
			}
		}

		public unsafe uint _MaxLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxLength);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxLength)) = value;
			}
		}

		public unsafe uint _MinLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinLength);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinLength)) = value;
			}
		}

		public unsafe Hashtable _AttDefList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttDefList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttDefList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ElementContent()
		{
			Il2CppClassPointerStore<ElementContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "ElementContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementContent>.NativeClassPtr);
			NativeFieldInfoPtr__ElementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_ElementDecl");
			NativeFieldInfoPtr__ContentAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_ContentAttr");
			NativeFieldInfoPtr__OrderAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_OrderAttr");
			NativeFieldInfoPtr__MasterGroupRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_MasterGroupRequired");
			NativeFieldInfoPtr__ExistTerminal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_ExistTerminal");
			NativeFieldInfoPtr__AllowDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_AllowDataType");
			NativeFieldInfoPtr__HasDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_HasDataType");
			NativeFieldInfoPtr__HasType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_HasType");
			NativeFieldInfoPtr__EnumerationRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_EnumerationRequired");
			NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_MinVal");
			NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_MaxVal");
			NativeFieldInfoPtr__MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_MaxLength");
			NativeFieldInfoPtr__MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_MinLength");
			NativeFieldInfoPtr__AttDefList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, "_AttDefList");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementContent>.NativeClassPtr, 100667218);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementContent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ElementContent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class AttributeContent : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__AttDef;

		private static readonly System.IntPtr NativeFieldInfoPtr__Name;

		private static readonly System.IntPtr NativeFieldInfoPtr__Prefix;

		private static readonly System.IntPtr NativeFieldInfoPtr__Required;

		private static readonly System.IntPtr NativeFieldInfoPtr__MinVal;

		private static readonly System.IntPtr NativeFieldInfoPtr__MaxVal;

		private static readonly System.IntPtr NativeFieldInfoPtr__MaxLength;

		private static readonly System.IntPtr NativeFieldInfoPtr__MinLength;

		private static readonly System.IntPtr NativeFieldInfoPtr__EnumerationRequired;

		private static readonly System.IntPtr NativeFieldInfoPtr__HasDataType;

		private static readonly System.IntPtr NativeFieldInfoPtr__Global;

		private static readonly System.IntPtr NativeFieldInfoPtr__Default;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SchemaAttDef _AttDef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttDef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttDef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XmlQualifiedName _Name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string _Prefix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Prefix);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Prefix)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe bool _Required
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Required);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Required)) = value;
			}
		}

		public unsafe uint _MinVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinVal);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinVal)) = value;
			}
		}

		public unsafe uint _MaxVal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxVal);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxVal)) = value;
			}
		}

		public unsafe uint _MaxLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxLength);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxLength)) = value;
			}
		}

		public unsafe uint _MinLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinLength);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinLength)) = value;
			}
		}

		public unsafe bool _EnumerationRequired
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnumerationRequired);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnumerationRequired)) = value;
			}
		}

		public unsafe bool _HasDataType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasDataType);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HasDataType)) = value;
			}
		}

		public unsafe bool _Global
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Global);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Global)) = value;
			}
		}

		public unsafe Object _Default
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Default);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Default)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static AttributeContent()
		{
			Il2CppClassPointerStore<AttributeContent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "AttributeContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr);
			NativeFieldInfoPtr__AttDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_AttDef");
			NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_Name");
			NativeFieldInfoPtr__Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_Prefix");
			NativeFieldInfoPtr__Required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_Required");
			NativeFieldInfoPtr__MinVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_MinVal");
			NativeFieldInfoPtr__MaxVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_MaxVal");
			NativeFieldInfoPtr__MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_MaxLength");
			NativeFieldInfoPtr__MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_MinLength");
			NativeFieldInfoPtr__EnumerationRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_EnumerationRequired");
			NativeFieldInfoPtr__HasDataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_HasDataType");
			NativeFieldInfoPtr__Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_Global");
			NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, "_Default");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr, 100667219);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeContent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public AttributeContent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class XdrBuildFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0;

		static XdrBuildFunction()
		{
			Il2CppClassPointerStore<XdrBuildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrBuildFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuildFunction>.NativeClassPtr, 100667220);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuildFunction>.NativeClassPtr, 100667221);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 852815, RefRangeEnd = 852819, XrefRangeStart = 852815, XrefRangeEnd = 852819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrBuildFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuildFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XdrBuilder builder, Object obj, string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XdrBuildFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XdrBuildFunction(System.Action<XdrBuilder, Object, string> P_0)
		{
			return DelegateSupport.ConvertDelegate<XdrBuildFunction>((System.Delegate)P_0);
		}

		public static XdrBuildFunction operator +(XdrBuildFunction P_0, XdrBuildFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XdrBuildFunction>();
		}

		public static XdrBuildFunction operator -(XdrBuildFunction P_0, XdrBuildFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XdrBuildFunction>();
			}
			return (XdrBuildFunction)obj;
		}
	}

	public sealed class XdrInitFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0;

		static XdrInitFunction()
		{
			Il2CppClassPointerStore<XdrInitFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrInitFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrInitFunction>.NativeClassPtr, 100667222);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrInitFunction>.NativeClassPtr, 100667223);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 862581, RefRangeEnd = 862587, XrefRangeStart = 862581, XrefRangeEnd = 862587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrInitFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrInitFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XdrBuilder builder, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XdrInitFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XdrInitFunction(System.Action<XdrBuilder, Object> P_0)
		{
			return DelegateSupport.ConvertDelegate<XdrInitFunction>((System.Delegate)P_0);
		}

		public static XdrInitFunction operator +(XdrInitFunction P_0, XdrInitFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XdrInitFunction>();
		}

		public static XdrInitFunction operator -(XdrInitFunction P_0, XdrInitFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XdrInitFunction>();
			}
			return (XdrInitFunction)obj;
		}
	}

	public sealed class XdrBeginChildFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0;

		static XdrBeginChildFunction()
		{
			Il2CppClassPointerStore<XdrBeginChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrBeginChildFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBeginChildFunction>.NativeClassPtr, 100667224);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBeginChildFunction>.NativeClassPtr, 100667225);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrBeginChildFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBeginChildFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XdrBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XdrBeginChildFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XdrBeginChildFunction(System.Action<XdrBuilder> P_0)
		{
			return DelegateSupport.ConvertDelegate<XdrBeginChildFunction>((System.Delegate)P_0);
		}

		public static XdrBeginChildFunction operator +(XdrBeginChildFunction P_0, XdrBeginChildFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XdrBeginChildFunction>();
		}

		public static XdrBeginChildFunction operator -(XdrBeginChildFunction P_0, XdrBeginChildFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XdrBeginChildFunction>();
			}
			return (XdrBeginChildFunction)obj;
		}
	}

	public sealed class XdrEndChildFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0;

		static XdrEndChildFunction()
		{
			Il2CppClassPointerStore<XdrEndChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrEndChildFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrEndChildFunction>.NativeClassPtr, 100667226);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrEndChildFunction>.NativeClassPtr, 100667227);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrEndChildFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrEndChildFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XdrBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XdrBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XdrEndChildFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XdrEndChildFunction(System.Action<XdrBuilder> P_0)
		{
			return DelegateSupport.ConvertDelegate<XdrEndChildFunction>((System.Delegate)P_0);
		}

		public static XdrEndChildFunction operator +(XdrEndChildFunction P_0, XdrEndChildFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XdrEndChildFunction>();
		}

		public static XdrEndChildFunction operator -(XdrEndChildFunction P_0, XdrEndChildFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XdrEndChildFunction>();
			}
			return (XdrEndChildFunction)obj;
		}
	}

	public sealed class XdrAttributeEntry : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Attribute;

		private static readonly System.IntPtr NativeFieldInfoPtr__SchemaFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr__Datatype;

		private static readonly System.IntPtr NativeFieldInfoPtr__BuildFunc;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0;

		public unsafe SchemaNames.Token _Attribute
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attribute);
				return *(SchemaNames.Token*)num;
			}
			set
			{
				*(SchemaNames.Token*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attribute)) = value;
			}
		}

		public unsafe int _SchemaFlags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SchemaFlags);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SchemaFlags)) = value;
			}
		}

		public unsafe XmlSchemaDatatype _Datatype
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Datatype);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Datatype)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XdrBuildFunction _BuildFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuildFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XdrBuildFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BuildFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static XdrAttributeEntry()
		{
			Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrAttributeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr);
			NativeFieldInfoPtr__Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr, "_Attribute");
			NativeFieldInfoPtr__SchemaFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr, "_SchemaFlags");
			NativeFieldInfoPtr__Datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr, "_Datatype");
			NativeFieldInfoPtr__BuildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr, "_BuildFunc");
			NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr, 100667228);
			NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr, 100667229);
		}

		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 935979, RefRangeEnd = 936011, XrefRangeStart = 935972, XrefRangeEnd = 935979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuildFunction build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&a);
			*(XmlTokenizedType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ttype;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)build);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_XdrBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936018, RefRangeEnd = 936020, XrefRangeStart = 936011, XrefRangeEnd = 936018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrAttributeEntry(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuildFunction build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrAttributeEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&a);
			*(XmlTokenizedType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ttype;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &schemaFlags;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)build);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Token_XmlTokenizedType_Int32_XdrBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XdrAttributeEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class XdrEntry : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Name;

		private static readonly System.IntPtr NativeFieldInfoPtr__NextStates;

		private static readonly System.IntPtr NativeFieldInfoPtr__Attributes;

		private static readonly System.IntPtr NativeFieldInfoPtr__InitFunc;

		private static readonly System.IntPtr NativeFieldInfoPtr__BeginChildFunc;

		private static readonly System.IntPtr NativeFieldInfoPtr__EndChildFunc;

		private static readonly System.IntPtr NativeFieldInfoPtr__AllowText;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0;

		public unsafe SchemaNames.Token _Name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name);
				return *(SchemaNames.Token*)num;
			}
			set
			{
				*(SchemaNames.Token*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name)) = value;
			}
		}

		public unsafe Il2CppStructArray<int> _NextStates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NextStates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NextStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<XdrAttributeEntry> _Attributes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attributes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Attributes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XdrInitFunction _InitFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InitFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XdrInitFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InitFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XdrBeginChildFunction _BeginChildFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BeginChildFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XdrBeginChildFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BeginChildFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XdrEndChildFunction _EndChildFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndChildFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XdrEndChildFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EndChildFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool _AllowText
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AllowText);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AllowText)) = value;
			}
		}

		static XdrEntry()
		{
			Il2CppClassPointerStore<XdrEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "XdrEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr);
			NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_Name");
			NativeFieldInfoPtr__NextStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_NextStates");
			NativeFieldInfoPtr__Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_Attributes");
			NativeFieldInfoPtr__InitFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_InitFunc");
			NativeFieldInfoPtr__BeginChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_BeginChildFunc");
			NativeFieldInfoPtr__EndChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_EndChildFunc");
			NativeFieldInfoPtr__AllowText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, "_AllowText");
			NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr, 100667230);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936020, XrefRangeEnd = 936026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrEntry(SchemaNames.Token n, Il2CppStructArray<int> states, Il2CppReferenceArray<XdrAttributeEntry> attributes, XdrInitFunction init, XdrBeginChildFunction begin, XdrEndChildFunction end, bool fText)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = (nint)(&n);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)states);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)init);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)begin);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)end);
			*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fText;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Token_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_XdrAttributeEntry_XdrInitFunction_XdrBeginChildFunction_XdrEndChildFunction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XdrEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Root_Element;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Root_SubElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_ElementType_SubElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_AttributeType_SubElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Group_SubElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Root_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_ElementType_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_AttributeType_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Element_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Attribute_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_Group_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_S_SchemaEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr__SchemaInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetNamespace;

	private static readonly System.IntPtr NativeFieldInfoPtr__reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr__contentValidator;

	private static readonly System.IntPtr NativeFieldInfoPtr__CurState;

	private static readonly System.IntPtr NativeFieldInfoPtr__NextState;

	private static readonly System.IntPtr NativeFieldInfoPtr__StateHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr__GroupStack;

	private static readonly System.IntPtr NativeFieldInfoPtr__XdrName;

	private static readonly System.IntPtr NativeFieldInfoPtr__XdrPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr__ElementDef;

	private static readonly System.IntPtr NativeFieldInfoPtr__GroupDef;

	private static readonly System.IntPtr NativeFieldInfoPtr__AttributeDef;

	private static readonly System.IntPtr NativeFieldInfoPtr__UndefinedAttributeTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr__BaseDecl;

	private static readonly System.IntPtr NativeFieldInfoPtr__NameTable;

	private static readonly System.IntPtr NativeFieldInfoPtr__SchemaNames;

	private static readonly System.IntPtr NativeFieldInfoPtr__CurNsMgr;

	private static readonly System.IntPtr NativeFieldInfoPtr__Text;

	private static readonly System.IntPtr NativeFieldInfoPtr_validationEventHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr__UndeclaredElements;

	private static readonly System.IntPtr NativeFieldInfoPtr_xmlResolver;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushGroupInfo_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopGroupInfo_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOrder_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;

	public unsafe static Il2CppStructArray<int> S_XDR_Root_Element
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Root_Element, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Root_Element, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> S_XDR_Root_SubElements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Root_SubElements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Root_SubElements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> S_XDR_ElementType_SubElements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_ElementType_SubElements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_ElementType_SubElements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> S_XDR_AttributeType_SubElements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_AttributeType_SubElements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_AttributeType_SubElements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> S_XDR_Group_SubElements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Group_SubElements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Group_SubElements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_Root_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Root_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Root_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_ElementType_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_ElementType_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_ElementType_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_AttributeType_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_AttributeType_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_AttributeType_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_Element_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Element_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Element_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_Attribute_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Attribute_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Attribute_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_Group_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_Group_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_Group_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_ElementDataType_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrAttributeEntry> S_XDR_AttributeDataType_Attributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XdrEntry> S_SchemaEntries
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_S_SchemaEntries, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XdrEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_S_SchemaEntries, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SchemaInfo _SchemaInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SchemaInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SchemaInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _TargetNamespace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetNamespace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetNamespace)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe XmlReader _reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PositionInfo positionInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ParticleContentValidator _contentValidator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__contentValidator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParticleContentValidator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__contentValidator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XdrEntry _CurState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XdrEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XdrEntry _NextState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NextState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XdrEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NextState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HWStack _StateHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StateHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HWStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StateHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HWStack _GroupStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GroupStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HWStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GroupStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _XdrName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__XdrName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__XdrName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _XdrPrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__XdrPrefix);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__XdrPrefix)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ElementContent _ElementDef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElementDef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ElementContent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElementDef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GroupContent _GroupDef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GroupDef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GroupContent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GroupDef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AttributeContent _AttributeDef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttributeDef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AttributeContent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttributeDef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeclBaseInfo _UndefinedAttributeTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UndefinedAttributeTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeclBaseInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UndefinedAttributeTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeclBaseInfo _BaseDecl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BaseDecl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeclBaseInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BaseDecl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlNameTable _NameTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NameTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NameTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SchemaNames _SchemaNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SchemaNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SchemaNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlNamespaceManager _CurNsMgr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurNsMgr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurNsMgr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _Text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Text)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe ValidationEventHandler validationEventHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validationEventHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validationEventHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable _UndeclaredElements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UndeclaredElements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UndeclaredElements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlResolver xmlResolver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xmlResolver);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xmlResolver)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlResolver XmlResolver
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static XdrBuilder()
	{
		Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XdrBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_S_XDR_Root_Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_Element");
		NativeFieldInfoPtr_S_XDR_Root_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_SubElements");
		NativeFieldInfoPtr_S_XDR_ElementType_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementType_SubElements");
		NativeFieldInfoPtr_S_XDR_AttributeType_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeType_SubElements");
		NativeFieldInfoPtr_S_XDR_Group_SubElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Group_SubElements");
		NativeFieldInfoPtr_S_XDR_Root_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Root_Attributes");
		NativeFieldInfoPtr_S_XDR_ElementType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementType_Attributes");
		NativeFieldInfoPtr_S_XDR_AttributeType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeType_Attributes");
		NativeFieldInfoPtr_S_XDR_Element_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Element_Attributes");
		NativeFieldInfoPtr_S_XDR_Attribute_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Attribute_Attributes");
		NativeFieldInfoPtr_S_XDR_Group_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_Group_Attributes");
		NativeFieldInfoPtr_S_XDR_ElementDataType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_ElementDataType_Attributes");
		NativeFieldInfoPtr_S_XDR_AttributeDataType_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_XDR_AttributeDataType_Attributes");
		NativeFieldInfoPtr_S_SchemaEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "S_SchemaEntries");
		NativeFieldInfoPtr__SchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_SchemaInfo");
		NativeFieldInfoPtr__TargetNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_TargetNamespace");
		NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_reader");
		NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "positionInfo");
		NativeFieldInfoPtr__contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_contentValidator");
		NativeFieldInfoPtr__CurState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_CurState");
		NativeFieldInfoPtr__NextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_NextState");
		NativeFieldInfoPtr__StateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_StateHistory");
		NativeFieldInfoPtr__GroupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_GroupStack");
		NativeFieldInfoPtr__XdrName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_XdrName");
		NativeFieldInfoPtr__XdrPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_XdrPrefix");
		NativeFieldInfoPtr__ElementDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_ElementDef");
		NativeFieldInfoPtr__GroupDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_GroupDef");
		NativeFieldInfoPtr__AttributeDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_AttributeDef");
		NativeFieldInfoPtr__UndefinedAttributeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_UndefinedAttributeTypes");
		NativeFieldInfoPtr__BaseDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_BaseDecl");
		NativeFieldInfoPtr__NameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_NameTable");
		NativeFieldInfoPtr__SchemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_SchemaNames");
		NativeFieldInfoPtr__CurNsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_CurNsMgr");
		NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_Text");
		NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "validationEventHandler");
		NativeFieldInfoPtr__UndeclaredElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "_UndeclaredElements");
		NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, "xmlResolver");
		NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667127);
		NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667128);
		NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667129);
		NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667130);
		NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667131);
		NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667132);
		NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667133);
		NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667134);
		NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667135);
		NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667136);
		NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667137);
		NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667138);
		NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667139);
		NativeMethodInfoPtr_PushGroupInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667140);
		NativeMethodInfoPtr_PopGroupInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667141);
		NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667142);
		NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667143);
		NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667144);
		NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667145);
		NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667146);
		NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667147);
		NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667148);
		NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667151);
		NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667154);
		NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667155);
		NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667156);
		NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667157);
		NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667158);
		NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667159);
		NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667160);
		NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667161);
		NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667162);
		NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667164);
		NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667165);
		NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667166);
		NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667167);
		NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667168);
		NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667169);
		NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667170);
		NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667171);
		NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667172);
		NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667173);
		NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667174);
		NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667175);
		NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667176);
		NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667177);
		NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667178);
		NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667179);
		NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667180);
		NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667181);
		NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667182);
		NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667183);
		NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667184);
		NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667185);
		NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667186);
		NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667187);
		NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667188);
		NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667189);
		NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667190);
		NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667191);
		NativeMethodInfoPtr_AddOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667192);
		NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667193);
		NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667194);
		NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667195);
		NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667196);
		NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667197);
		NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667198);
		NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667199);
		NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667200);
		NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667201);
		NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667202);
		NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667203);
		NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667204);
		NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667205);
		NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667208);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667209);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667210);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr, 100667211);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 936074, RefRangeEnd = 936075, XrefRangeStart = 936026, XrefRangeEnd = 936074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XdrBuilder(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrBuilder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curmgr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sinfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetNamspace);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventhandler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_SchemaInfo_String_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936075, XrefRangeEnd = 936088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ProcessElement(string prefix, string name, string ns)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ns);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936088, XrefRangeEnd = 936098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ProcessAttribute(string prefix, string name, string ns, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(ns);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936098, XrefRangeEnd = 936130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadSchema(string uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSchema_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936130, XrefRangeEnd = 936136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsXdrSchema(string uri)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsXdrSchema_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsContentParsed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936136, XrefRangeEnd = 936143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ProcessMarkup(Il2CppReferenceArray<XmlNode> markup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)markup);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936143, XrefRangeEnd = 936148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ProcessCData(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override void StartChildren()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936148, XrefRangeEnd = 936157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EndChildren()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936157, XrefRangeEnd = 936161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Push()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936161, XrefRangeEnd = 936170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936170, XrefRangeEnd = 936177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushGroupInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushGroupInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936177, XrefRangeEnd = 936186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopGroupInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopGroupInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936186, XrefRangeEnd = 937031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitRoot(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitRoot_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937031, XrefRangeEnd = 937039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildRoot_Name(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildRoot_Name_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildRoot_ID(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildRoot_ID_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937039, XrefRangeEnd = 937049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BeginRoot(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BeginRoot_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937049, XrefRangeEnd = 937093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndRoot(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndRoot_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937093, XrefRangeEnd = 937108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitElementType(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitElementType_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937108, XrefRangeEnd = 937124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_Name(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_Name_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937124, XrefRangeEnd = 937127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_Content(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_Content_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937127, XrefRangeEnd = 937133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_Model(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_Model_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937133, XrefRangeEnd = 937136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_Order(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_Order_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937136, XrefRangeEnd = 937152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_DtType(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_DtType_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937152, XrefRangeEnd = 937165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_DtValues(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937165, XrefRangeEnd = 937181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937181, XrefRangeEnd = 937197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElementType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937197, XrefRangeEnd = 937229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BeginElementType(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BeginElementType_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937229, XrefRangeEnd = 937275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndElementType(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndElementType_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937275, XrefRangeEnd = 937286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitAttributeType(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitAttributeType_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937286, XrefRangeEnd = 937303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_Name(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_Name_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937303, XrefRangeEnd = 937307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_Required(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_Required_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937307, XrefRangeEnd = 937309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_Default(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_Default_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937309, XrefRangeEnd = 937330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_DtType(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_DtType_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937330, XrefRangeEnd = 937343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_DtValues_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937343, XrefRangeEnd = 937359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_DtMaxLength_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937359, XrefRangeEnd = 937375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttributeType_DtMinLength_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937375, XrefRangeEnd = 937380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BeginAttributeType(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BeginAttributeType_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937380, XrefRangeEnd = 937391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndAttributeType(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndAttributeType_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937391, XrefRangeEnd = 937395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitElement(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitElement_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937395, XrefRangeEnd = 937412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElement_Type(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElement_Type_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937412, XrefRangeEnd = 937416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElement_MinOccurs(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElement_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937416, XrefRangeEnd = 937420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildElement_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937420, XrefRangeEnd = 937425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndElement(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndElement_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937425, XrefRangeEnd = 937431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitAttribute(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitAttribute_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937431, XrefRangeEnd = 937440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttribute_Type(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttribute_Type_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937440, XrefRangeEnd = 937444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttribute_Required(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttribute_Required_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937444, XrefRangeEnd = 937446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildAttribute_Default(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildAttribute_Default_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937446, XrefRangeEnd = 937491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BeginAttribute(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BeginAttribute_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937491, XrefRangeEnd = 937493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndAttribute(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndAttribute_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937493, XrefRangeEnd = 937506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitGroup(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitGroup_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937506, XrefRangeEnd = 937513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildGroup_Order(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildGroup_Order_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937513, XrefRangeEnd = 937517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildGroup_MinOccurs_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937517, XrefRangeEnd = 937521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, Object obj, string prefix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_BuildGroup_MaxOccurs_Private_Static_Void_XdrBuilder_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937521, XrefRangeEnd = 937548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndGroup(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndGroup_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937548, XrefRangeEnd = 937556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitElementDtType(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitElementDtType_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937556, XrefRangeEnd = 937567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndElementDtType(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndElementDtType_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937567, XrefRangeEnd = 937571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_InitAttributeDtType(XdrBuilder builder, Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_InitAttributeDtType_Private_Static_Void_XdrBuilder_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937571, XrefRangeEnd = 937581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void XDR_EndAttributeDtType(XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_EndAttributeDtType_Private_Static_Void_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 937590, RefRangeEnd = 937591, XrefRangeStart = 937581, XrefRangeEnd = 937590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetNextState(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937591, XrefRangeEnd = 937592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSkipableElement(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937592, XrefRangeEnd = 937595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSkipableAttribute(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSkipableAttribute_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937598, RefRangeEnd = 937600, XrefRangeStart = 937595, XrefRangeEnd = 937598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetOrder(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrder_Private_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937611, RefRangeEnd = 937613, XrefRangeStart = 937600, XrefRangeEnd = 937611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937625, RefRangeEnd = 937627, XrefRangeStart = 937613, XrefRangeEnd = 937625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsYes(Object obj, XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsYes_Private_Static_Boolean_Object_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937637, RefRangeEnd = 937639, XrefRangeStart = 937627, XrefRangeEnd = 937637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ParseMinOccurs(Object obj, XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMinOccurs_Private_Static_UInt32_Object_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937652, RefRangeEnd = 937654, XrefRangeStart = 937639, XrefRangeEnd = 937652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ParseMaxOccurs(Object obj, XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMaxOccurs_Private_Static_UInt32_Object_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937654, XrefRangeEnd = 937657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pContent);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cMin;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cMax;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleMinMax_Private_Static_Void_ParticleContentValidator_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937657, XrefRangeEnd = 937670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseDtMaxLength(ref uint cVal, Object obj, XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref cVal);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDtMaxLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937670, XrefRangeEnd = 937683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseDtMinLength(ref uint cVal, Object obj, XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref cVal);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDtMinLength_Private_Static_Void_byref_UInt32_Object_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937683, XrefRangeEnd = 937687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cMin);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cMax;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareMinMaxLength_Private_Static_Void_UInt32_UInt32_XdrBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937687, XrefRangeEnd = 937689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ParseInteger(string str, ref uint n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseInteger_Private_Static_Boolean_String_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937694, RefRangeEnd = 937696, XrefRangeStart = 937689, XrefRangeEnd = 937694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void XDR_CheckAttributeDefault(DeclBaseInfo decl, SchemaAttDef pAttdef)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pAttdef);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_XDR_CheckAttributeDefault_Private_Void_DeclBaseInfo_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pAttdef);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fRequired;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAttributePresence_Private_Void_SchemaAttDef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 937699, RefRangeEnd = 937700, XrefRangeStart = 937696, XrefRangeEnd = 937699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetContent(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContent_Private_Int32_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937700, XrefRangeEnd = 937703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetModel(XmlQualifiedName qname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)qname);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetModel_Private_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937703, XrefRangeEnd = 937716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlSchemaDatatype CheckDatatype(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDatatype_Private_XmlSchemaDatatype_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937719, RefRangeEnd = 937721, XrefRangeStart = 937716, XrefRangeEnd = 937719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDefaultAttValue(SchemaAttDef attDef)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attDef);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDefaultAttValue_Private_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsGlobal(int flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGlobal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 937727, RefRangeEnd = 937728, XrefRangeStart = 937721, XrefRangeEnd = 937727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValidationEvent(string code, Il2CppStringArray args, XmlSeverityType severity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		*(XmlSeverityType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &severity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937728, XrefRangeEnd = 937730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValidationEvent(string code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 937736, RefRangeEnd = 937785, XrefRangeStart = 937730, XrefRangeEnd = 937736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValidationEvent(string code, string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(msg);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 937794, RefRangeEnd = 937796, XrefRangeStart = 937785, XrefRangeEnd = 937794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		*(XmlSeverityType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &severity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XdrBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
