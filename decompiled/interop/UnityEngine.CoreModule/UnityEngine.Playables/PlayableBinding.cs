using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables;

public sealed class PlayableBinding : Il2CppSystem.ValueType
{
	public sealed class CreateOutputMethod : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0;

		static CreateOutputMethod()
		{
			Il2CppClassPointerStore<CreateOutputMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "CreateOutputMethod");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateOutputMethod>.NativeClassPtr, 100667433);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateOutputMethod>.NativeClassPtr, 100667434);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229711, RefRangeEnd = 1229713, XrefRangeStart = 1229708, XrefRangeEnd = 1229711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateOutputMethod(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateOutputMethod>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual PlayableOutput Invoke(PlayableGraph graph, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&graph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public CreateOutputMethod(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator CreateOutputMethod(System.Func<PlayableGraph, string, PlayableOutput> P_0)
		{
			return DelegateSupport.ConvertDelegate<CreateOutputMethod>((System.Delegate)P_0);
		}

		public static CreateOutputMethod operator +(CreateOutputMethod P_0, CreateOutputMethod P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<CreateOutputMethod>();
		}

		public static CreateOutputMethod operator -(CreateOutputMethod P_0, CreateOutputMethod P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<CreateOutputMethod>();
			}
			return (CreateOutputMethod)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StreamName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceBindingType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CreateOutputMethod;

	private static readonly System.IntPtr NativeFieldInfoPtr_None;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultDuration;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_streamName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0;

	public unsafe string m_StreamName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreamName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StreamName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Object m_SourceObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Type m_SourceBindingType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceBindingType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SourceBindingType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CreateOutputMethod m_CreateOutputMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreateOutputMethod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CreateOutputMethod>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreateOutputMethod)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<PlayableBinding> None
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_None, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayableBinding>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_None, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static double DefaultDuration
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultDuration, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultDuration, (void*)(&value));
		}
	}

	public unsafe string streamName
	{
		[CallerCount(255)]
		[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_streamName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			m_StreamName = value;
		}
	}

	public unsafe Object sourceObject
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 765815, RefRangeEnd = 765844, XrefRangeStart = 765815, XrefRangeEnd = 765844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			m_SourceObject = value;
		}
	}

	public Il2CppSystem.Type outputTargetType => m_SourceBindingType;

	public Il2CppSystem.Type sourceBindingType
	{
		get
		{
			return m_SourceBindingType;
		}
		set
		{
		}
	}

	public DataStreamType streamType
	{
		get
		{
			return DataStreamType.None;
		}
		set
		{
		}
	}

	static PlayableBinding()
	{
		Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr);
		NativeFieldInfoPtr_m_StreamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_StreamName");
		NativeFieldInfoPtr_m_SourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceObject");
		NativeFieldInfoPtr_m_SourceBindingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceBindingType");
		NativeFieldInfoPtr_m_CreateOutputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_CreateOutputMethod");
		NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "None");
		NativeFieldInfoPtr_DefaultDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "DefaultDuration");
		NativeMethodInfoPtr_get_streamName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667428);
		NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667431);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1229721, RefRangeEnd = 1229722, XrefRangeStart = 1229713, XrefRangeEnd = 1229721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableOutput CreateOutput(PlayableGraph graph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&graph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1229726, RefRangeEnd = 1229728, XrefRangeStart = 1229722, XrefRangeEnd = 1229726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableBinding CreateInternal(string name, Object sourceObject, Il2CppSystem.Type sourceType, CreateOutputMethod createFunction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createFunction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayableBinding(pointer);
	}

	public PlayableBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PlayableBinding()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr))
	{
	}
}
