namespace Microsoft.eShopWeb.ApplicationCore.Configuration
{
    public class JwtSettings
    {
        public const string SectionName = "JwtSettings";
        
        public string SecretKey { get; set; } = string.Empty;
        public bool RequireHttpsMetadata { get; set; } = false;
        public bool SaveToken { get; set; } = true;
        public bool ValidateIssuerSigningKey { get; set; } = true;
        public bool ValidateIssuer { get; set; } = false;
        public bool ValidateAudience { get; set; } = false;
        public int ExpirationDays { get; set; } = 7;
    }
}