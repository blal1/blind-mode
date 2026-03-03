using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509FindType")]
public enum X509FindType
{
	FindByThumbprint,
	FindBySubjectName,
	FindBySubjectDistinguishedName,
	FindByIssuerName,
	FindByIssuerDistinguishedName,
	FindBySerialNumber,
	FindByTimeValid,
	FindByTimeNotYetValid,
	FindByTimeExpired,
	FindByTemplateName,
	FindByApplicationPolicy,
	FindByCertificatePolicy,
	FindByExtension,
	FindByKeyUsage,
	FindBySubjectKeyIdentifier
}
