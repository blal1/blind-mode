using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema;

public sealed class XsdBuilder : SchemaBuilder
{
	[OriginalName("System.Xml.dll", "", "State")]
	public enum State
	{
		Root,
		Schema,
		Annotation,
		Include,
		Import,
		Element,
		Attribute,
		AttributeGroup,
		AttributeGroupRef,
		AnyAttribute,
		Group,
		GroupRef,
		All,
		Choice,
		Sequence,
		Any,
		Notation,
		SimpleType,
		ComplexType,
		ComplexContent,
		ComplexContentRestriction,
		ComplexContentExtension,
		SimpleContent,
		SimpleContentExtension,
		SimpleContentRestriction,
		SimpleTypeUnion,
		SimpleTypeList,
		SimpleTypeRestriction,
		Unique,
		Key,
		KeyRef,
		Selector,
		Field,
		MinExclusive,
		MinInclusive,
		MaxExclusive,
		MaxInclusive,
		TotalDigits,
		FractionDigits,
		Length,
		MinLength,
		MaxLength,
		Enumeration,
		Pattern,
		WhiteSpace,
		AppInfo,
		Documentation,
		Redefine
	}

	public sealed class XsdBuildFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0;

		static XsdBuildFunction()
		{
			Il2CppClassPointerStore<XsdBuildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdBuildFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuildFunction>.NativeClassPtr, 100668550);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuildFunction>.NativeClassPtr, 100668551);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 862581, RefRangeEnd = 862587, XrefRangeStart = 862581, XrefRangeEnd = 862587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdBuildFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuildFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XsdBuilder builder, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XsdBuildFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XsdBuildFunction(System.Action<XsdBuilder, string> P_0)
		{
			return DelegateSupport.ConvertDelegate<XsdBuildFunction>((System.Delegate)P_0);
		}

		public static XsdBuildFunction operator +(XsdBuildFunction P_0, XsdBuildFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XsdBuildFunction>();
		}

		public static XsdBuildFunction operator -(XsdBuildFunction P_0, XsdBuildFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XsdBuildFunction>();
			}
			return (XsdBuildFunction)obj;
		}
	}

	public sealed class XsdInitFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0;

		static XsdInitFunction()
		{
			Il2CppClassPointerStore<XsdInitFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdInitFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdInitFunction>.NativeClassPtr, 100668552);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdInitFunction>.NativeClassPtr, 100668553);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 862581, RefRangeEnd = 862587, XrefRangeStart = 862581, XrefRangeEnd = 862587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdInitFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdInitFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XsdBuilder builder, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XsdInitFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XsdInitFunction(System.Action<XsdBuilder, string> P_0)
		{
			return DelegateSupport.ConvertDelegate<XsdInitFunction>((System.Delegate)P_0);
		}

		public static XsdInitFunction operator +(XsdInitFunction P_0, XsdInitFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XsdInitFunction>();
		}

		public static XsdInitFunction operator -(XsdInitFunction P_0, XsdInitFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XsdInitFunction>();
			}
			return (XsdInitFunction)obj;
		}
	}

	public sealed class XsdEndChildFunction : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0;

		static XsdEndChildFunction()
		{
			Il2CppClassPointerStore<XsdEndChildFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdEndChildFunction");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdEndChildFunction>.NativeClassPtr, 100668554);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdEndChildFunction>.NativeClassPtr, 100668555);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdEndChildFunction(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdEndChildFunction>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(XsdBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_XsdBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XsdEndChildFunction(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator XsdEndChildFunction(System.Action<XsdBuilder> P_0)
		{
			return DelegateSupport.ConvertDelegate<XsdEndChildFunction>((System.Delegate)P_0);
		}

		public static XsdEndChildFunction operator +(XsdEndChildFunction P_0, XsdEndChildFunction P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<XsdEndChildFunction>();
		}

		public static XsdEndChildFunction operator -(XsdEndChildFunction P_0, XsdEndChildFunction P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<XsdEndChildFunction>();
			}
			return (XsdEndChildFunction)obj;
		}
	}

	public sealed class XsdAttributeEntry : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Attribute;

		private static readonly System.IntPtr NativeFieldInfoPtr_BuildFunc;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0;

		public unsafe SchemaNames.Token Attribute
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Attribute);
				return *(SchemaNames.Token*)num;
			}
			set
			{
				*(SchemaNames.Token*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Attribute)) = value;
			}
		}

		public unsafe XsdBuildFunction BuildFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XsdBuildFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuildFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static XsdAttributeEntry()
		{
			Il2CppClassPointerStore<XsdAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdAttributeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdAttributeEntry>.NativeClassPtr);
			NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdAttributeEntry>.NativeClassPtr, "Attribute");
			NativeFieldInfoPtr_BuildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdAttributeEntry>.NativeClassPtr, "BuildFunc");
			NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdAttributeEntry>.NativeClassPtr, 100668556);
		}

		[CallerCount(171)]
		[CachedScanResults(RefRangeStart = 351582, RefRangeEnd = 351753, XrefRangeStart = 351582, XrefRangeEnd = 351753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdAttributeEntry(SchemaNames.Token a, XsdBuildFunction build)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdAttributeEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)build);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Token_XsdBuildFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XsdAttributeEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class XsdEntry : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Name;

		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentState;

		private static readonly System.IntPtr NativeFieldInfoPtr_NextStates;

		private static readonly System.IntPtr NativeFieldInfoPtr_Attributes;

		private static readonly System.IntPtr NativeFieldInfoPtr_InitFunc;

		private static readonly System.IntPtr NativeFieldInfoPtr_EndChildFunc;

		private static readonly System.IntPtr NativeFieldInfoPtr_ParseContent;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0;

		public unsafe SchemaNames.Token Name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
				return *(SchemaNames.Token*)num;
			}
			set
			{
				*(SchemaNames.Token*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name)) = value;
			}
		}

		public unsafe State CurrentState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState);
				return *(State*)num;
			}
			set
			{
				*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		public unsafe Il2CppStructArray<State> NextStates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextStates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextStates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppReferenceArray<XsdAttributeEntry> Attributes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Attributes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Attributes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XsdInitFunction InitFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XsdInitFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XsdEndChildFunction EndChildFunc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndChildFunc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XsdEndChildFunction>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndChildFunc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool ParseContent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParseContent);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParseContent)) = value;
			}
		}

		static XsdEntry()
		{
			Il2CppClassPointerStore<XsdEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "XsdEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr);
			NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "Name");
			NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "CurrentState");
			NativeFieldInfoPtr_NextStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "NextStates");
			NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "Attributes");
			NativeFieldInfoPtr_InitFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "InitFunc");
			NativeFieldInfoPtr_EndChildFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "EndChildFunc");
			NativeFieldInfoPtr_ParseContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, "ParseContent");
			NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr, 100668557);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950047, XrefRangeEnd = 950052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdEntry(SchemaNames.Token n, State state, Il2CppStructArray<State> nextStates, Il2CppReferenceArray<XsdAttributeEntry> attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdEntry>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = (nint)(&n);
			*(State**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nextStates);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attributes);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)init);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)end);
			*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &parseContent;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Token_State_Il2CppStructArray_1_State_Il2CppReferenceArray_1_XsdAttributeEntry_XsdInitFunction_XsdEndChildFunction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public XsdEntry(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class BuilderNamespaceManager : XmlNamespaceManager
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nsMgr;

		private static readonly System.IntPtr NativeFieldInfoPtr_reader;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		public unsafe XmlNamespaceManager nsMgr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nsMgr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nsMgr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe XmlReader reader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlReader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static BuilderNamespaceManager()
		{
			Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "BuilderNamespaceManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr);
			NativeFieldInfoPtr_nsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr, "nsMgr");
			NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr, "reader");
			NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr, 100668558);
			NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr, 100668559);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 950065, RefRangeEnd = 950066, XrefRangeStart = 950052, XrefRangeEnd = 950065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuilderNamespaceManager>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nsMgr);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_XmlNamespaceManager_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		public BuilderNamespaceManager(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SchemaElement;

	private static readonly System.IntPtr NativeFieldInfoPtr_SchemaSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttributeSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElementSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexTypeSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleContentSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleContentExtensionSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleContentRestrictionSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexContentSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexContentExtensionSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexContentRestrictionSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeRestrictionSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeListSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeUnionSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_RedefineSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttributeGroupSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChoiceSequenceSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_IdentityConstraintSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnnotationSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnnotatedSubelements;

	private static readonly System.IntPtr NativeFieldInfoPtr_SchemaAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttributeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ElementAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexTypeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleContentAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleContentExtensionAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleContentRestrictionAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexContentAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexContentExtensionAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ComplexContentRestrictionAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeRestrictionAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeUnionAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SimpleTypeListAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttributeGroupAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttributeGroupRefAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupRefAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ParticleAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnyAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IdentityConstraintAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SelectorAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_FieldAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_NotationAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IncludeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_ImportAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_FacetAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnyAttributeAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_DocumentationAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AppinfoAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_RedefineAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnnotationAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_SchemaEntries;

	private static readonly System.IntPtr NativeFieldInfoPtr_DerivationMethodValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_DerivationMethodStrings;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormStringValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseStringValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProcessContentsStringValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentEntry;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextEntry;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasChild;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_containerStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameTable;

	private static readonly System.IntPtr NativeFieldInfoPtr_schemaNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_namespaceManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_canIncludeImport;

	private static readonly System.IntPtr NativeFieldInfoPtr_schema;

	private static readonly System.IntPtr NativeFieldInfoPtr_xso;

	private static readonly System.IntPtr NativeFieldInfoPtr_element;

	private static readonly System.IntPtr NativeFieldInfoPtr_anyElement;

	private static readonly System.IntPtr NativeFieldInfoPtr_attribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_anyAttribute;

	private static readonly System.IntPtr NativeFieldInfoPtr_complexType;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleType;

	private static readonly System.IntPtr NativeFieldInfoPtr_complexContent;

	private static readonly System.IntPtr NativeFieldInfoPtr_complexContentExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_complexContentRestriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleContent;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleContentExtension;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleContentRestriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleTypeUnion;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleTypeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_simpleTypeRestriction;

	private static readonly System.IntPtr NativeFieldInfoPtr_group;

	private static readonly System.IntPtr NativeFieldInfoPtr_groupRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_all;

	private static readonly System.IntPtr NativeFieldInfoPtr_choice;

	private static readonly System.IntPtr NativeFieldInfoPtr_sequence;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle;

	private static readonly System.IntPtr NativeFieldInfoPtr_attributeGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_attributeGroupRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_notation;

	private static readonly System.IntPtr NativeFieldInfoPtr_identityConstraint;

	private static readonly System.IntPtr NativeFieldInfoPtr_xpath;

	private static readonly System.IntPtr NativeFieldInfoPtr_include;

	private static readonly System.IntPtr NativeFieldInfoPtr_import;

	private static readonly System.IntPtr NativeFieldInfoPtr_annotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_appInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_documentation;

	private static readonly System.IntPtr NativeFieldInfoPtr_facet;

	private static readonly System.IntPtr NativeFieldInfoPtr_markup;

	private static readonly System.IntPtr NativeFieldInfoPtr_redefine;

	private static readonly System.IntPtr NativeFieldInfoPtr_validationEventHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_unhandledAttributes;

	private static readonly System.IntPtr NativeFieldInfoPtr_namespaces;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Push_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordPosition_Private_Void_0;

	public unsafe static Il2CppStructArray<State> SchemaElement
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SchemaElement, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SchemaElement, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SchemaSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SchemaSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SchemaSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> AttributeSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttributeSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttributeSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> ElementSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ElementSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ElementSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> ComplexTypeSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexTypeSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexTypeSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleContentSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleContentSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleContentSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleContentExtensionSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleContentExtensionSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleContentExtensionSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleContentRestrictionSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleContentRestrictionSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleContentRestrictionSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> ComplexContentSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexContentSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexContentSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> ComplexContentExtensionSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexContentExtensionSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexContentExtensionSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> ComplexContentRestrictionSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexContentRestrictionSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexContentRestrictionSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleTypeSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleTypeRestrictionSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeRestrictionSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeRestrictionSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleTypeListSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeListSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeListSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> SimpleTypeUnionSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeUnionSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeUnionSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> RedefineSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RedefineSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RedefineSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> AttributeGroupSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttributeGroupSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttributeGroupSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> GroupSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GroupSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GroupSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> AllSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AllSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AllSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> ChoiceSequenceSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChoiceSequenceSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChoiceSequenceSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> IdentityConstraintSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IdentityConstraintSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IdentityConstraintSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> AnnotationSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AnnotationSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AnnotationSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<State> AnnotatedSubelements
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AnnotatedSubelements, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<State>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AnnotatedSubelements, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SchemaAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SchemaAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SchemaAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AttributeAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttributeAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttributeAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ElementAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ElementAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ElementAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ComplexTypeAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexTypeAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexTypeAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleContentAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleContentAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleContentAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleContentExtensionAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleContentExtensionAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleContentExtensionAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleContentRestrictionAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleContentRestrictionAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleContentRestrictionAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ComplexContentAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexContentAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexContentAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ComplexContentExtensionAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexContentExtensionAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexContentExtensionAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ComplexContentRestrictionAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ComplexContentRestrictionAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ComplexContentRestrictionAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleTypeAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleTypeRestrictionAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeRestrictionAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeRestrictionAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleTypeUnionAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeUnionAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeUnionAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SimpleTypeListAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SimpleTypeListAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SimpleTypeListAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AttributeGroupAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttributeGroupAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttributeGroupAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AttributeGroupRefAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AttributeGroupRefAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AttributeGroupRefAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> GroupAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GroupAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GroupAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> GroupRefAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GroupRefAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GroupRefAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ParticleAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ParticleAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ParticleAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AnyAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AnyAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AnyAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> IdentityConstraintAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IdentityConstraintAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IdentityConstraintAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> SelectorAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SelectorAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SelectorAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> FieldAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FieldAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FieldAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> NotationAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NotationAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NotationAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> IncludeAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IncludeAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IncludeAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> ImportAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ImportAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ImportAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> FacetAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FacetAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FacetAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AnyAttributeAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AnyAttributeAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AnyAttributeAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> DocumentationAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DocumentationAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DocumentationAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AppinfoAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AppinfoAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AppinfoAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> RedefineAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RedefineAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RedefineAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdAttributeEntry> AnnotationAttributes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AnnotationAttributes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdAttributeEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AnnotationAttributes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<XsdEntry> SchemaEntries
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SchemaEntries, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XsdEntry>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SchemaEntries, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> DerivationMethodValues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DerivationMethodValues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DerivationMethodValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray DerivationMethodStrings
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DerivationMethodStrings, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DerivationMethodStrings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray FormStringValues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormStringValues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormStringValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray UseStringValues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UseStringValues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UseStringValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStringArray ProcessContentsStringValues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ProcessContentsStringValues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ProcessContentsStringValues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlReader reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe XsdEntry currentEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentEntry);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XsdEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XsdEntry nextEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextEntry);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XsdEntry>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasChild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasChild);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasChild)) = value;
		}
	}

	public unsafe HWStack stateHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HWStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Stack containerStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_containerStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlNameTable nameTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameTable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameTable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SchemaNames schemaNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schemaNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlNamespaceManager namespaceManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namespaceManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namespaceManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool canIncludeImport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canIncludeImport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canIncludeImport)) = value;
		}
	}

	public unsafe XmlSchema schema
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schema);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_schema)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaObject xso
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xso);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xso)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaElement element
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_element);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_element)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAny anyElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyElement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAny>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyElement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAttribute attribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attribute);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attribute)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAnyAttribute anyAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyAttribute);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anyAttribute)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaComplexType complexType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleType simpleType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaComplexContent complexContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexContent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaComplexContent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexContent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaComplexContentExtension complexContentExtension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexContentExtension);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaComplexContentExtension>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexContentExtension)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaComplexContentRestriction complexContentRestriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexContentRestriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaComplexContentRestriction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_complexContentRestriction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleContent simpleContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleContent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleContent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleContentExtension simpleContentExtension
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleContentExtension);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentExtension>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleContentExtension)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleContentRestriction simpleContentRestriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleContentRestriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleContentRestriction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleContentRestriction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleTypeUnion simpleTypeUnion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTypeUnion);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeUnion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTypeUnion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleTypeList simpleTypeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTypeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTypeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSimpleTypeRestriction simpleTypeRestriction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTypeRestriction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeRestriction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simpleTypeRestriction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaGroup group
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaGroupRef groupRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaGroupRef>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groupRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAll all
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_all);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAll>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_all)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaChoice choice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choice);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choice)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaSequence sequence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sequence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaSequence>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sequence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaParticle particle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAttributeGroup attributeGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAttributeGroupRef attributeGroupRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeGroupRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroupRef>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attributeGroupRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaNotation notation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaNotation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaIdentityConstraint identityConstraint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identityConstraint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaIdentityConstraint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identityConstraint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaXPath xpath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xpath);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaXPath>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xpath)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaInclude include
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_include);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaInclude>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_include)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaImport import
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_import);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaImport>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_import)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAnnotation annotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_annotation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_annotation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaAppInfo appInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaAppInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaDocumentation documentation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaDocumentation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_documentation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaFacet facet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaFacet>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<XmlNode> markup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlSchemaRedefine redefine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redefine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaRedefine>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_redefine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe ArrayList unhandledAttributes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unhandledAttributes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unhandledAttributes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Hashtable namespaces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namespaces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_namespaces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SchemaNames.Token CurrentElement
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 583852, RefRangeEnd = 583859, XrefRangeStart = 583852, XrefRangeEnd = 583859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SchemaNames.Token*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe SchemaNames.Token ParentElement
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 950196, RefRangeEnd = 950208, XrefRangeStart = 950193, XrefRangeEnd = 950196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SchemaNames.Token*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe XmlSchemaObject ParentContainer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 950210, RefRangeEnd = 950212, XrefRangeStart = 950208, XrefRangeEnd = 950210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
		}
	}

	static XsdBuilder()
	{
		Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_SchemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaElement");
		NativeFieldInfoPtr_SchemaSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaSubelements");
		NativeFieldInfoPtr_AttributeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeSubelements");
		NativeFieldInfoPtr_ElementSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ElementSubelements");
		NativeFieldInfoPtr_ComplexTypeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexTypeSubelements");
		NativeFieldInfoPtr_SimpleContentSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentSubelements");
		NativeFieldInfoPtr_SimpleContentExtensionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentExtensionSubelements");
		NativeFieldInfoPtr_SimpleContentRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentRestrictionSubelements");
		NativeFieldInfoPtr_ComplexContentSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentSubelements");
		NativeFieldInfoPtr_ComplexContentExtensionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentExtensionSubelements");
		NativeFieldInfoPtr_ComplexContentRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentRestrictionSubelements");
		NativeFieldInfoPtr_SimpleTypeSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeSubelements");
		NativeFieldInfoPtr_SimpleTypeRestrictionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeRestrictionSubelements");
		NativeFieldInfoPtr_SimpleTypeListSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeListSubelements");
		NativeFieldInfoPtr_SimpleTypeUnionSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeUnionSubelements");
		NativeFieldInfoPtr_RedefineSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "RedefineSubelements");
		NativeFieldInfoPtr_AttributeGroupSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupSubelements");
		NativeFieldInfoPtr_GroupSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupSubelements");
		NativeFieldInfoPtr_AllSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AllSubelements");
		NativeFieldInfoPtr_ChoiceSequenceSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ChoiceSequenceSubelements");
		NativeFieldInfoPtr_IdentityConstraintSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IdentityConstraintSubelements");
		NativeFieldInfoPtr_AnnotationSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotationSubelements");
		NativeFieldInfoPtr_AnnotatedSubelements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotatedSubelements");
		NativeFieldInfoPtr_SchemaAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaAttributes");
		NativeFieldInfoPtr_AttributeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeAttributes");
		NativeFieldInfoPtr_ElementAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ElementAttributes");
		NativeFieldInfoPtr_ComplexTypeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexTypeAttributes");
		NativeFieldInfoPtr_SimpleContentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentAttributes");
		NativeFieldInfoPtr_SimpleContentExtensionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentExtensionAttributes");
		NativeFieldInfoPtr_SimpleContentRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleContentRestrictionAttributes");
		NativeFieldInfoPtr_ComplexContentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentAttributes");
		NativeFieldInfoPtr_ComplexContentExtensionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentExtensionAttributes");
		NativeFieldInfoPtr_ComplexContentRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ComplexContentRestrictionAttributes");
		NativeFieldInfoPtr_SimpleTypeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeAttributes");
		NativeFieldInfoPtr_SimpleTypeRestrictionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeRestrictionAttributes");
		NativeFieldInfoPtr_SimpleTypeUnionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeUnionAttributes");
		NativeFieldInfoPtr_SimpleTypeListAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SimpleTypeListAttributes");
		NativeFieldInfoPtr_AttributeGroupAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupAttributes");
		NativeFieldInfoPtr_AttributeGroupRefAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AttributeGroupRefAttributes");
		NativeFieldInfoPtr_GroupAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupAttributes");
		NativeFieldInfoPtr_GroupRefAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "GroupRefAttributes");
		NativeFieldInfoPtr_ParticleAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ParticleAttributes");
		NativeFieldInfoPtr_AnyAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnyAttributes");
		NativeFieldInfoPtr_IdentityConstraintAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IdentityConstraintAttributes");
		NativeFieldInfoPtr_SelectorAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SelectorAttributes");
		NativeFieldInfoPtr_FieldAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FieldAttributes");
		NativeFieldInfoPtr_NotationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "NotationAttributes");
		NativeFieldInfoPtr_IncludeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "IncludeAttributes");
		NativeFieldInfoPtr_ImportAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ImportAttributes");
		NativeFieldInfoPtr_FacetAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FacetAttributes");
		NativeFieldInfoPtr_AnyAttributeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnyAttributeAttributes");
		NativeFieldInfoPtr_DocumentationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DocumentationAttributes");
		NativeFieldInfoPtr_AppinfoAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AppinfoAttributes");
		NativeFieldInfoPtr_RedefineAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "RedefineAttributes");
		NativeFieldInfoPtr_AnnotationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "AnnotationAttributes");
		NativeFieldInfoPtr_SchemaEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "SchemaEntries");
		NativeFieldInfoPtr_DerivationMethodValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DerivationMethodValues");
		NativeFieldInfoPtr_DerivationMethodStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "DerivationMethodStrings");
		NativeFieldInfoPtr_FormStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "FormStringValues");
		NativeFieldInfoPtr_UseStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "UseStringValues");
		NativeFieldInfoPtr_ProcessContentsStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "ProcessContentsStringValues");
		NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "reader");
		NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "positionInfo");
		NativeFieldInfoPtr_currentEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "currentEntry");
		NativeFieldInfoPtr_nextEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "nextEntry");
		NativeFieldInfoPtr_hasChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "hasChild");
		NativeFieldInfoPtr_stateHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "stateHistory");
		NativeFieldInfoPtr_containerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "containerStack");
		NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "nameTable");
		NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "schemaNames");
		NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "namespaceManager");
		NativeFieldInfoPtr_canIncludeImport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "canIncludeImport");
		NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "schema");
		NativeFieldInfoPtr_xso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "xso");
		NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "element");
		NativeFieldInfoPtr_anyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "anyElement");
		NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attribute");
		NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "anyAttribute");
		NativeFieldInfoPtr_complexType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexType");
		NativeFieldInfoPtr_simpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleType");
		NativeFieldInfoPtr_complexContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContent");
		NativeFieldInfoPtr_complexContentExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContentExtension");
		NativeFieldInfoPtr_complexContentRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "complexContentRestriction");
		NativeFieldInfoPtr_simpleContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContent");
		NativeFieldInfoPtr_simpleContentExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContentExtension");
		NativeFieldInfoPtr_simpleContentRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleContentRestriction");
		NativeFieldInfoPtr_simpleTypeUnion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeUnion");
		NativeFieldInfoPtr_simpleTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeList");
		NativeFieldInfoPtr_simpleTypeRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "simpleTypeRestriction");
		NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "group");
		NativeFieldInfoPtr_groupRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "groupRef");
		NativeFieldInfoPtr_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "all");
		NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "choice");
		NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "sequence");
		NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "particle");
		NativeFieldInfoPtr_attributeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attributeGroup");
		NativeFieldInfoPtr_attributeGroupRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "attributeGroupRef");
		NativeFieldInfoPtr_notation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "notation");
		NativeFieldInfoPtr_identityConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "identityConstraint");
		NativeFieldInfoPtr_xpath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "xpath");
		NativeFieldInfoPtr_include = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "include");
		NativeFieldInfoPtr_import = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "import");
		NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "annotation");
		NativeFieldInfoPtr_appInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "appInfo");
		NativeFieldInfoPtr_documentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "documentation");
		NativeFieldInfoPtr_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "facet");
		NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "markup");
		NativeFieldInfoPtr_redefine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "redefine");
		NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "validationEventHandler");
		NativeFieldInfoPtr_unhandledAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "unhandledAttributes");
		NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, "namespaces");
		NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668412);
		NativeMethodInfoPtr_ProcessElement_Internal_Virtual_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668413);
		NativeMethodInfoPtr_ProcessAttribute_Internal_Virtual_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668414);
		NativeMethodInfoPtr_IsContentParsed_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668415);
		NativeMethodInfoPtr_ProcessMarkup_Internal_Virtual_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668416);
		NativeMethodInfoPtr_ProcessCData_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668417);
		NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668418);
		NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668419);
		NativeMethodInfoPtr_Push_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668420);
		NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668421);
		NativeMethodInfoPtr_get_CurrentElement_Private_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668422);
		NativeMethodInfoPtr_get_ParentElement_Private_get_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668423);
		NativeMethodInfoPtr_get_ParentContainer_Private_get_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668424);
		NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668425);
		NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668426);
		NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668427);
		NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668428);
		NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668429);
		NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668430);
		NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668431);
		NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668432);
		NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668433);
		NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668434);
		NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668435);
		NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668436);
		NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668437);
		NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668438);
		NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668439);
		NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668440);
		NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668441);
		NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668442);
		NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668443);
		NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668444);
		NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668445);
		NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668446);
		NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668447);
		NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668448);
		NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668449);
		NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668450);
		NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668451);
		NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668452);
		NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668453);
		NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668454);
		NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668455);
		NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668456);
		NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668457);
		NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668458);
		NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668459);
		NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668460);
		NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668461);
		NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668462);
		NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668463);
		NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668464);
		NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668465);
		NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668466);
		NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668467);
		NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668468);
		NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668469);
		NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668470);
		NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668471);
		NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668472);
		NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668473);
		NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668474);
		NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668475);
		NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668476);
		NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668477);
		NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668478);
		NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668479);
		NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668480);
		NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668481);
		NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668482);
		NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668483);
		NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668484);
		NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668485);
		NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668486);
		NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668487);
		NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668488);
		NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668489);
		NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668490);
		NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668491);
		NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668492);
		NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668493);
		NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668494);
		NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668495);
		NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668496);
		NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668497);
		NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668498);
		NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668499);
		NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668500);
		NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668501);
		NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668502);
		NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668503);
		NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668504);
		NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668505);
		NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668506);
		NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668507);
		NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668508);
		NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668509);
		NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668510);
		NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668511);
		NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668512);
		NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668513);
		NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668514);
		NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668515);
		NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668516);
		NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668517);
		NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668518);
		NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668519);
		NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668520);
		NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668521);
		NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668522);
		NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668523);
		NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668524);
		NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668525);
		NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668526);
		NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668527);
		NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668528);
		NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668529);
		NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668530);
		NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668531);
		NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668532);
		NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668533);
		NativeMethodInfoPtr_GetNextState_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668534);
		NativeMethodInfoPtr_IsSkipableElement_Private_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668535);
		NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668536);
		NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668537);
		NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668538);
		NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668539);
		NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668540);
		NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668541);
		NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668542);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668543);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668544);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668545);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668546);
		NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668547);
		NativeMethodInfoPtr_RecordPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr, 100668548);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950066, XrefRangeEnd = 950106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdBuilder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)curmgr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schema);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameTable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)schemaNames);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventhandler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_XmlNamespaceManager_XmlSchema_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950106, XrefRangeEnd = 950114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950114, XrefRangeEnd = 950130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950130, XrefRangeEnd = 950133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950133, XrefRangeEnd = 950144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void StartChildren()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950144, XrefRangeEnd = 950151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EndChildren()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndChildren_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950151, XrefRangeEnd = 950186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Push()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950186, XrefRangeEnd = 950193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe XmlSchemaObject GetContainer(State state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContainer_Private_XmlSchemaObject_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 950248, RefRangeEnd = 950250, XrefRangeStart = 950212, XrefRangeEnd = 950248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetContainer(State state, Object container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&state);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetContainer_Private_Void_State_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950250, XrefRangeEnd = 950251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAnnotated_Id(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAnnotated_Id_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950251, XrefRangeEnd = 950258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchema_AttributeFormDefault_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950258, XrefRangeEnd = 950265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchema_ElementFormDefault_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950265, XrefRangeEnd = 950267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSchema_TargetNamespace(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchema_TargetNamespace_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950267, XrefRangeEnd = 950269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSchema_Version(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchema_Version_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950269, XrefRangeEnd = 950272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSchema_FinalDefault(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchema_FinalDefault_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950272, XrefRangeEnd = 950275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSchema_BlockDefault(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSchema_BlockDefault_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950275, XrefRangeEnd = 950277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSchema(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSchema_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950277, XrefRangeEnd = 950288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitInclude(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitInclude_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950288, XrefRangeEnd = 950290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildInclude_SchemaLocation(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildInclude_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950290, XrefRangeEnd = 950301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitImport(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitImport_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950301, XrefRangeEnd = 950303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildImport_Namespace(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildImport_Namespace_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950303, XrefRangeEnd = 950305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildImport_SchemaLocation(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildImport_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950305, XrefRangeEnd = 950316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitRedefine(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitRedefine_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950316, XrefRangeEnd = 950318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildRedefine_SchemaLocation_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void EndRedefine(XsdBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRedefine_Private_Static_Void_XsdBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950318, XrefRangeEnd = 950326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAttribute(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAttribute_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950326, XrefRangeEnd = 950328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Default(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Default_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950328, XrefRangeEnd = 950330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Fixed(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Fixed_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950330, XrefRangeEnd = 950337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Form(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Form_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950337, XrefRangeEnd = 950344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Use(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Use_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950344, XrefRangeEnd = 950349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Ref(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Ref_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950349, XrefRangeEnd = 950351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950351, XrefRangeEnd = 950356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttribute_Type(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttribute_Type_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950356, XrefRangeEnd = 950364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitElement(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitElement_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950364, XrefRangeEnd = 950369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Abstract(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Abstract_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950369, XrefRangeEnd = 950372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Block(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Block_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950372, XrefRangeEnd = 950374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Default(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Default_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950374, XrefRangeEnd = 950381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Form(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Form_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950381, XrefRangeEnd = 950386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_SubstitutionGroup_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950386, XrefRangeEnd = 950389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Final(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Final_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950389, XrefRangeEnd = 950391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Fixed(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Fixed_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950391, XrefRangeEnd = 950393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_MaxOccurs(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_MaxOccurs_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950393, XrefRangeEnd = 950395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_MinOccurs(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_MinOccurs_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950395, XrefRangeEnd = 950397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950397, XrefRangeEnd = 950402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Nillable(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Nillable_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950402, XrefRangeEnd = 950407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Ref(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Ref_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950407, XrefRangeEnd = 950412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildElement_Type(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildElement_Type_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950412, XrefRangeEnd = 950435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleType(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleType_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950435, XrefRangeEnd = 950437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleType_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleType_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950437, XrefRangeEnd = 950440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleType_Final(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleType_Final_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950440, XrefRangeEnd = 950451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleTypeUnion(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleTypeUnion_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950451, XrefRangeEnd = 950459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleTypeUnion_MemberTypes_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950459, XrefRangeEnd = 950470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleTypeList(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleTypeList_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950470, XrefRangeEnd = 950475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleTypeList_ItemType_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950475, XrefRangeEnd = 950486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleTypeRestriction(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleTypeRestriction_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950486, XrefRangeEnd = 950491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleTypeRestriction_Base_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950491, XrefRangeEnd = 950502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitComplexType(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitComplexType_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950502, XrefRangeEnd = 950507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexType_Abstract(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexType_Abstract_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950507, XrefRangeEnd = 950510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexType_Block(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexType_Block_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950510, XrefRangeEnd = 950513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexType_Final(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexType_Final_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950513, XrefRangeEnd = 950517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexType_Mixed(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexType_Mixed_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950517, XrefRangeEnd = 950519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexType_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexType_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950519, XrefRangeEnd = 950534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitComplexContent(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitComplexContent_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950534, XrefRangeEnd = 950539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexContent_Mixed(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexContent_Mixed_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950539, XrefRangeEnd = 950551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitComplexContentExtension(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitComplexContentExtension_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950551, XrefRangeEnd = 950556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexContentExtension_Base(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexContentExtension_Base_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950556, XrefRangeEnd = 950563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitComplexContentRestriction(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitComplexContentRestriction_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950563, XrefRangeEnd = 950568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildComplexContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950568, XrefRangeEnd = 950583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleContent(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleContent_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950583, XrefRangeEnd = 950595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleContentExtension(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleContentExtension_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950595, XrefRangeEnd = 950600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleContentExtension_Base_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950600, XrefRangeEnd = 950612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSimpleContentRestriction(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSimpleContentRestriction_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950612, XrefRangeEnd = 950617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSimpleContentRestriction_Base_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950617, XrefRangeEnd = 950625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAttributeGroup(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAttributeGroup_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950625, XrefRangeEnd = 950627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttributeGroup_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttributeGroup_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950627, XrefRangeEnd = 950635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAttributeGroupRef(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAttributeGroupRef_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950635, XrefRangeEnd = 950640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAttributeGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950640, XrefRangeEnd = 950654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAnyAttribute(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAnyAttribute_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950654, XrefRangeEnd = 950656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAnyAttribute_Namespace_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950656, XrefRangeEnd = 950663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAnyAttribute_ProcessContents_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950663, XrefRangeEnd = 950671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitGroup(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGroup_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950671, XrefRangeEnd = 950673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildGroup_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildGroup_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950673, XrefRangeEnd = 950682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitGroupRef(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitGroupRef_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950682, XrefRangeEnd = 950684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildParticle_MaxOccurs(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildParticle_MaxOccurs_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950684, XrefRangeEnd = 950686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildParticle_MinOccurs(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildParticle_MinOccurs_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950686, XrefRangeEnd = 950691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildGroupRef_Ref(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildGroupRef_Ref_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950691, XrefRangeEnd = 950700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAll(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAll_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950700, XrefRangeEnd = 950709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitChoice(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitChoice_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950709, XrefRangeEnd = 950718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSequence(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSequence_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950718, XrefRangeEnd = 950727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAny(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAny_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950727, XrefRangeEnd = 950729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAny_Namespace(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAny_Namespace_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950729, XrefRangeEnd = 950736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAny_ProcessContents(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAny_ProcessContents_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950736, XrefRangeEnd = 950744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitNotation(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitNotation_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950744, XrefRangeEnd = 950746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildNotation_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildNotation_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950746, XrefRangeEnd = 950748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildNotation_Public(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildNotation_Public_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950748, XrefRangeEnd = 950750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildNotation_System(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildNotation_System_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950750, XrefRangeEnd = 950819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitFacet(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitFacet_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950819, XrefRangeEnd = 950823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildFacet_Fixed(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildFacet_Fixed_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950823, XrefRangeEnd = 950825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildFacet_Value(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildFacet_Value_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950825, XrefRangeEnd = 950848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitIdentityConstraint(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitIdentityConstraint_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950848, XrefRangeEnd = 950850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildIdentityConstraint_Name(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildIdentityConstraint_Name_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950850, XrefRangeEnd = 950863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildIdentityConstraint_Refer_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950863, XrefRangeEnd = 950874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitSelector(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSelector_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950874, XrefRangeEnd = 950876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildSelector_XPath(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildSelector_XPath_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950876, XrefRangeEnd = 950887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitField(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitField_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildField_XPath(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildField_XPath_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950887, XrefRangeEnd = 950900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAnnotation(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAnnotation_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950900, XrefRangeEnd = 950912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitAppinfo(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitAppinfo_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950912, XrefRangeEnd = 950917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildAppinfo_Source(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildAppinfo_Source_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950917, XrefRangeEnd = 950919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndAppinfo(XsdBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndAppinfo_Private_Static_Void_XsdBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950919, XrefRangeEnd = 950931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitDocumentation(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDocumentation_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950931, XrefRangeEnd = 950936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildDocumentation_Source(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildDocumentation_Source_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950936, XrefRangeEnd = 950940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildDocumentation_XmlLang(XsdBuilder builder, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildDocumentation_XmlLang_Private_Static_Void_XsdBuilder_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950940, XrefRangeEnd = 950942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndDocumentation(XsdBuilder builder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndDocumentation_Private_Static_Void_XsdBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 950949, RefRangeEnd = 950951, XrefRangeStart = 950942, XrefRangeEnd = 950949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAttribute(XmlSchemaObject value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAttribute_Private_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 950965, RefRangeEnd = 950970, XrefRangeStart = 950951, XrefRangeEnd = 950965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddParticle(XmlSchemaParticle particle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddParticle_Private_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 950979, RefRangeEnd = 950980, XrefRangeStart = 950970, XrefRangeEnd = 950979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 950984, RefRangeEnd = 950986, XrefRangeStart = 950980, XrefRangeEnd = 950984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMinOccurs(XmlSchemaParticle particle, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMinOccurs_Private_Void_XmlSchemaParticle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 950990, RefRangeEnd = 950992, XrefRangeStart = 950986, XrefRangeEnd = 950990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaxOccurs(XmlSchemaParticle particle, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaxOccurs_Private_Void_XmlSchemaParticle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 950999, RefRangeEnd = 951005, XrefRangeStart = 950992, XrefRangeEnd = 950999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ParseBoolean(string value, string attributeName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attributeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseBoolean_Private_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 951009, RefRangeEnd = 951016, XrefRangeStart = 951005, XrefRangeEnd = 951009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ParseEnum(string value, string attributeName, Il2CppStringArray values)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attributeName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseEnum_Private_Int32_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 951027, RefRangeEnd = 951041, XrefRangeStart = 951016, XrefRangeEnd = 951027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlQualifiedName ParseQName(string value, string attributeName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attributeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseQName_Private_XmlQualifiedName_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 951064, RefRangeEnd = 951071, XrefRangeStart = 951041, XrefRangeEnd = 951064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ParseBlockFinalEnum(string value, string attributeName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attributeName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseBlockFinalEnum_Private_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ParseUriReference(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseUriReference_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 951084, RefRangeEnd = 951087, XrefRangeStart = 951071, XrefRangeEnd = 951084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValidationEvent(string code, string arg0, string arg1, string arg2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arg2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValidationEvent_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 951093, RefRangeEnd = 951120, XrefRangeStart = 951087, XrefRangeEnd = 951093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 951126, RefRangeEnd = 951127, XrefRangeStart = 951120, XrefRangeEnd = 951126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 951133, RefRangeEnd = 951139, XrefRangeStart = 951127, XrefRangeEnd = 951133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951139, XrefRangeEnd = 951140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendValidationEvent(XmlSchemaException e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951140, XrefRangeEnd = 951143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XsdBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
