using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net;

[OriginalName("System.dll", "System.Net", "WebExceptionStatus")]
public enum WebExceptionStatus
{
	Success,
	NameResolutionFailure,
	ConnectFailure,
	ReceiveFailure,
	SendFailure,
	PipelineFailure,
	RequestCanceled,
	ProtocolError,
	ConnectionClosed,
	TrustFailure,
	SecureChannelFailure,
	ServerProtocolViolation,
	KeepAliveFailure,
	Pending,
	Timeout,
	ProxyNameResolutionFailure,
	UnknownError,
	MessageLengthLimitExceeded,
	CacheEntryNotFound,
	RequestProhibitedByCachePolicy,
	RequestProhibitedByProxy
}
