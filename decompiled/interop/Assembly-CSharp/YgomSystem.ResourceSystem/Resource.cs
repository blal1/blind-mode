using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002A2")]
public class Resource
{
	[Token(Token = "0x20002A3")]
	public enum Type
	{
		[Token(Token = "0x4000EFD")]
		None,
		[Token(Token = "0x4000EFE")]
		BuiltIn,
		[Token(Token = "0x4000EFF")]
		AssetBundle,
		[Token(Token = "0x4000F00")]
		Binary,
		[Token(Token = "0x4000F01")]
		Network,
		[Token(Token = "0x4000F02")]
		StreamingAssets,
		[Token(Token = "0x4000F03")]
		StreamingBinary,
		[Token(Token = "0x4000F04")]
		LocalFile,
		[Token(Token = "0x4000F05")]
		StreaminFile,
		[Token(Token = "0x4000F06")]
		PlayAssetDelivery
	}

	[Token(Token = "0x20002A4")]
	public struct HandlerData
	{
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x0")]
		public string path;

		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x8")]
		public ResourceManager.RequestCompleteHandler handler;

		[Token(Token = "0x600102A")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public HandlerData(string _path, ResourceManager.RequestCompleteHandler _handler)
		{
		}

		[Token(Token = "0x600102B")]
		[Address(RVA = "0xE6F4E0", Offset = "0xE6E6E0", VA = "0x180E6F4E0")]
		public void Call()
		{
		}
	}

	[Token(Token = "0x20002A5")]
	public delegate void CancelHandler(Resource res);

	[Token(Token = "0x20002A6")]
	public delegate void UnloadHandler(Resource res);

	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x10")]
	private List<HandlerData> handlerList;

	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0x18")]
	private CancelHandler cancelHandler;

	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x20")]
	private UnloadHandler unloadHandler;

	[Token(Token = "0x1700018A")]
	public List<HandlerData> CompleteHandlerList
	{
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018B")]
	public Type ResType
	{
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		[CompilerGenerated]
		get
		{
			return default(Type);
		}
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700018C")]
	public int RefCount
	{
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x7EB190", Offset = "0x7EA390", VA = "0x1807EB190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700018D")]
	public UnityEngine.Object[] Assets
	{
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700018E")]
	public byte[] Bytes
	{
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700018F")]
	public bool Cancel
	{
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000190")]
	public bool Error
	{
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x4166B0", Offset = "0x4158B0", VA = "0x1804166B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x416710", Offset = "0x415910", VA = "0x180416710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000191")]
	public bool Done
	{
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x648660", Offset = "0x647860", VA = "0x180648660")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001018")]
		[Address(RVA = "0xE7A000", Offset = "0xE79200", VA = "0x180E7A000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000192")]
	public bool Busy
	{
		[Token(Token = "0x6001019")]
		[Address(RVA = "0xE79FE0", Offset = "0xE791E0", VA = "0x180E79FE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600101A")]
		[Address(RVA = "0xE79FF0", Offset = "0xE791F0", VA = "0x180E79FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000193")]
	public bool Retry
	{
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x9C3510", Offset = "0x9C2710", VA = "0x1809C3510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x9C35E0", Offset = "0x9C27E0", VA = "0x1809C35E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000194")]
	public System.Type SystemType
	{
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600101E")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000195")]
	public string Path
	{
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000196")]
	public string LoadPath
	{
		[Token(Token = "0x6001021")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000197")]
	public bool DisableErrorNotify
	{
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x91E9C0", Offset = "0x91DBC0", VA = "0x18091E9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x91E9F0", Offset = "0x91DBF0", VA = "0x18091E9F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000198")]
	public ResourceManager.ReqType queueId
	{
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510")]
		[CompilerGenerated]
		get
		{
			return default(ResourceManager.ReqType);
		}
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x91EA10", Offset = "0x91DC10", VA = "0x18091EA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000199")]
	public bool needMaterialRebuild
	{
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x91E9B0", Offset = "0x91DBB0", VA = "0x18091E9B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x91E9E0", Offset = "0x91DBE0", VA = "0x18091E9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001002")]
	[Address(RVA = "0xE79B20", Offset = "0xE78D20", VA = "0x180E79B20")]
	public void AddHandler(string path, ResourceManager.RequestCompleteHandler handler)
	{
	}

	[Token(Token = "0x6001003")]
	[Address(RVA = "0xE79CF0", Offset = "0xE78EF0", VA = "0x180E79CF0")]
	public void CallHandler()
	{
	}

	[Token(Token = "0x6001004")]
	[Address(RVA = "0xE79DC0", Offset = "0xE78FC0", VA = "0x180E79DC0")]
	public void ClearHandler()
	{
	}

	[Token(Token = "0x6001005")]
	[Address(RVA = "0xE79A80", Offset = "0xE78C80", VA = "0x180E79A80")]
	public void AddCancelHandler(CancelHandler handler)
	{
	}

	[Token(Token = "0x6001006")]
	[Address(RVA = "0xE79E20", Offset = "0xE79020", VA = "0x180E79E20")]
	public void RemoveCancelHandler(CancelHandler handler)
	{
	}

	[Token(Token = "0x6001007")]
	[Address(RVA = "0xE79CD0", Offset = "0xE78ED0", VA = "0x180E79CD0")]
	public void CallCancel()
	{
	}

	[Token(Token = "0x6001008")]
	[Address(RVA = "0xE79C30", Offset = "0xE78E30", VA = "0x180E79C30")]
	public void AddUnloadHandler(UnloadHandler handler)
	{
	}

	[Token(Token = "0x6001009")]
	[Address(RVA = "0xE79EC0", Offset = "0xE790C0", VA = "0x180E79EC0")]
	public void RemoveUnloadHandler(UnloadHandler handler)
	{
	}

	[Token(Token = "0x600100A")]
	[Address(RVA = "0xE79DA0", Offset = "0xE78FA0", VA = "0x180E79DA0")]
	public void CallUnload()
	{
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0xE79F60", Offset = "0xE79160", VA = "0x180E79F60")]
	public Resource()
	{
	}
}
