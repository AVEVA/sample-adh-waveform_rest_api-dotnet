namespace SdsRestApiCore
{
    public class RoleTrusteeAccessControlEntry
    {
        public int AccessRights { get; set; }

        public int AccessType { get; set; }

        public Trustee Trustee { get; set; }
    }
}
